using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment10
{
    public partial class Assignment10_Lui : Form
    {
        int guessedInput;
        int[] intArr = new int[100];
        //Starting with position 0 in each array ask the user to guess the number currently selected from the array, enter it in the textbox 
        int guessCount = 0, correctCount = 0, incorrectCount = 0;
        //Create a Form, name it GuessANumber and create a randomly generated array containing 100 integer numbers. 
        public Assignment10_Lui()
        {
            InitializeComponent();
            //The random number generation for the array will be done in a method both when the array is first populated 
            //and when the array needs to be repopulated (requirement 10).
            //The form will have a textbox in which the user will enter an integer number to match against the next number in the array.
            //The form will have three buttons labeled Guess, Next Guess (disabled at startup) , and Exit GuessANumber.
            RandomGenerator rand = new RandomGenerator();
            intArr = rand.randomIntArrGenerator();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Next Guess (disabled at startup)
            nextGuessBtn.Enabled = false;
        }
        //When the user clicks the Exit GuessANumber button the application will close.
        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void hintLabel_MouseEnter(object sender, EventArgs e)
        {
            //The form will have a label that contains the text " Place your mouse here for a hint" that will generate a hint about 
            //the hidden number when the mouse is passed over the label 
            //If the current random number in the array is greater than 3 and less than 96 set the second label text to 
            //" It's not <random number + 3>  
            //Else set the second label text to " It's not <random number - 1>"
            int hint;
            if (intArr[guessCount] > 3 && intArr[guessCount] < 96)
            {
                hint = intArr[guessCount] + 3;
                hiddenHintsLabel.Text = "It's not " + hint.ToString();
            }
            else
            {
                hint = intArr[guessCount] - 1;
                hiddenHintsLabel.Text = "It's not " + hint.ToString();
            }
        }
        //click the Guess button. The number for each guess will be selected from the array in the index order (0 - 99). 
        private void guess_Click(object sender, EventArgs e)
        {
            try
            {
                guessedInput = Convert.ToInt32(userInput.Text);
                //When the Guess button is clicked:
                //The Guess button will be disabled.
                //The Next Guess button will be enabled.
                nextGuessBtn.Enabled = true;
                guessBtn.Enabled = false;
                hintLabel.Enabled = false;
                //If the numbers match add one to an accumulating correct guess counter and display the number of correct guesses made.
                //If the numbers do not match, add one to an accumulating incorrect guess counter and display the number of incorrect guesses made.
                //Disable the hint label.
                if (guessedInput == intArr[guessCount])
                {
                    correctCount++;
                    //A label will display a " You Win" message if the number entered in the textbox matches the number from the array
                    winOrLoseMessageLabel.Text = "You Win!!";
                    numOfCorrectGuessLabel.Text = correctCount.ToString();
                }
                else
                {
                    incorrectCount++;
                    ////" Sorry - You Lose; the number is:  <random number>" if the number does not match the number from the array.
                    winOrLoseMessageLabel.Text = "Sorry - You Lose; The number is: " + intArr[guessCount].ToString();
                    numOfIncorrectGuessLabel.Text = incorrectCount.ToString();
                }
            }
            catch
            {

            }
            finally
            {
                //Set the array index to the next number in the array.
                guessCount++;
                //If the user makes more than 100 guesses, the program should use the randomization method to repopulate the random numbers in the array 
                //and reset the array subscript to 0 so the guessing can start over, but continue the running totals.
                if (guessCount > 99)
                {
                    RandomGenerator rand = new RandomGenerator();
                    intArr = rand.randomIntArrGenerator();
                    guessCount = 0;
                }
            }
        }
        //When the user clicks the Next Guess button, the user can then make another guess 
        //and the program will use the next array number from the array.
        private void nextGuessBtn_Click(object sender, EventArgs e)
        {
            //The Next Guess button will be disabled.
            //The Guess button will be enabled.
            //The win/ lose message label will be cleared of text.
            //The hint label will be enabled.
            guessBtn.Enabled = true;
            hintLabel.Enabled = true;
            nextGuessBtn.Enabled = false;
            userInput.Text = "";
            hiddenHintsLabel.Text = "??";
            winOrLoseMessageLabel.Text = "";
        }
    }
}

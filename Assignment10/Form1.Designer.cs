
namespace Assignment10
{
    partial class Assignment10_Lui
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pickANumLabel = new System.Windows.Forms.Label();
            this.seeIfyouWinLabel = new System.Windows.Forms.Label();
            this.userInput = new System.Windows.Forms.TextBox();
            this.guessBtn = new System.Windows.Forms.Button();
            this.nextGuessBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.hintLabel = new System.Windows.Forms.Label();
            this.hiddenHintsLabel = new System.Windows.Forms.Label();
            this.correctLabel = new System.Windows.Forms.Label();
            this.incorrectLabel = new System.Windows.Forms.Label();
            this.numOfCorrectGuessLabel = new System.Windows.Forms.Label();
            this.numOfIncorrectGuessLabel = new System.Windows.Forms.Label();
            this.winOrLoseMessageLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pickANumLabel
            // 
            this.pickANumLabel.AutoSize = true;
            this.pickANumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pickANumLabel.Location = new System.Drawing.Point(42, 39);
            this.pickANumLabel.Name = "pickANumLabel";
            this.pickANumLabel.Size = new System.Drawing.Size(141, 25);
            this.pickANumLabel.TabIndex = 0;
            this.pickANumLabel.Text = "Pick a number.";
            // 
            // seeIfyouWinLabel
            // 
            this.seeIfyouWinLabel.AutoSize = true;
            this.seeIfyouWinLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seeIfyouWinLabel.Location = new System.Drawing.Point(42, 64);
            this.seeIfyouWinLabel.Name = "seeIfyouWinLabel";
            this.seeIfyouWinLabel.Size = new System.Drawing.Size(138, 25);
            this.seeIfyouWinLabel.TabIndex = 1;
            this.seeIfyouWinLabel.Text = "See if you win.";
            // 
            // userInput
            // 
            this.userInput.Location = new System.Drawing.Point(240, 55);
            this.userInput.Name = "userInput";
            this.userInput.Size = new System.Drawing.Size(113, 22);
            this.userInput.TabIndex = 2;
            // 
            // guessBtn
            // 
            this.guessBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guessBtn.Location = new System.Drawing.Point(416, 46);
            this.guessBtn.Name = "guessBtn";
            this.guessBtn.Size = new System.Drawing.Size(124, 35);
            this.guessBtn.TabIndex = 3;
            this.guessBtn.Text = "Guess";
            this.guessBtn.UseVisualStyleBackColor = true;
            this.guessBtn.Click += new System.EventHandler(this.guess_Click);
            // 
            // nextGuessBtn
            // 
            this.nextGuessBtn.AutoSize = true;
            this.nextGuessBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextGuessBtn.Location = new System.Drawing.Point(611, 46);
            this.nextGuessBtn.Name = "nextGuessBtn";
            this.nextGuessBtn.Size = new System.Drawing.Size(124, 35);
            this.nextGuessBtn.TabIndex = 4;
            this.nextGuessBtn.Text = "Next Guess";
            this.nextGuessBtn.UseVisualStyleBackColor = true;
            this.nextGuessBtn.Click += new System.EventHandler(this.nextGuessBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.AutoSize = true;
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(323, 315);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(199, 35);
            this.exitBtn.TabIndex = 5;
            this.exitBtn.Text = "Exit GuessANumber";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exit_Click);
            // 
            // hintLabel
            // 
            this.hintLabel.AutoSize = true;
            this.hintLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hintLabel.Location = new System.Drawing.Point(184, 114);
            this.hintLabel.Name = "hintLabel";
            this.hintLabel.Size = new System.Drawing.Size(291, 25);
            this.hintLabel.TabIndex = 6;
            this.hintLabel.Text = "Place your mouse here for a hint";
            this.hintLabel.MouseEnter += new System.EventHandler(this.hintLabel_MouseEnter);
            // 
            // hiddenHintsLabel
            // 
            this.hiddenHintsLabel.AutoSize = true;
            this.hiddenHintsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hiddenHintsLabel.Location = new System.Drawing.Point(184, 149);
            this.hiddenHintsLabel.Name = "hiddenHintsLabel";
            this.hiddenHintsLabel.Size = new System.Drawing.Size(34, 25);
            this.hiddenHintsLabel.TabIndex = 7;
            this.hiddenHintsLabel.Text = "??";
            // 
            // correctLabel
            // 
            this.correctLabel.AutoSize = true;
            this.correctLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correctLabel.Location = new System.Drawing.Point(606, 140);
            this.correctLabel.Name = "correctLabel";
            this.correctLabel.Size = new System.Drawing.Size(82, 25);
            this.correctLabel.TabIndex = 8;
            this.correctLabel.Text = "Correct:";
            // 
            // incorrectLabel
            // 
            this.incorrectLabel.AutoSize = true;
            this.incorrectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incorrectLabel.Location = new System.Drawing.Point(606, 172);
            this.incorrectLabel.Name = "incorrectLabel";
            this.incorrectLabel.Size = new System.Drawing.Size(93, 25);
            this.incorrectLabel.TabIndex = 9;
            this.incorrectLabel.Text = "Incorrect:";
            // 
            // numOfCorrectGuessLabel
            // 
            this.numOfCorrectGuessLabel.AutoSize = true;
            this.numOfCorrectGuessLabel.Location = new System.Drawing.Point(706, 147);
            this.numOfCorrectGuessLabel.Name = "numOfCorrectGuessLabel";
            this.numOfCorrectGuessLabel.Size = new System.Drawing.Size(0, 17);
            this.numOfCorrectGuessLabel.TabIndex = 10;
            // 
            // numOfIncorrectGuessLabel
            // 
            this.numOfIncorrectGuessLabel.AutoSize = true;
            this.numOfIncorrectGuessLabel.Location = new System.Drawing.Point(706, 179);
            this.numOfIncorrectGuessLabel.Name = "numOfIncorrectGuessLabel";
            this.numOfIncorrectGuessLabel.Size = new System.Drawing.Size(0, 17);
            this.numOfIncorrectGuessLabel.TabIndex = 11;
            // 
            // winOrLoseMessageLabel
            // 
            this.winOrLoseMessageLabel.AutoSize = true;
            this.winOrLoseMessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winOrLoseMessageLabel.Location = new System.Drawing.Point(42, 254);
            this.winOrLoseMessageLabel.Name = "winOrLoseMessageLabel";
            this.winOrLoseMessageLabel.Size = new System.Drawing.Size(0, 25);
            this.winOrLoseMessageLabel.TabIndex = 12;
            // 
            // Assignment10_Lui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.winOrLoseMessageLabel);
            this.Controls.Add(this.numOfIncorrectGuessLabel);
            this.Controls.Add(this.numOfCorrectGuessLabel);
            this.Controls.Add(this.incorrectLabel);
            this.Controls.Add(this.correctLabel);
            this.Controls.Add(this.hiddenHintsLabel);
            this.Controls.Add(this.hintLabel);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.nextGuessBtn);
            this.Controls.Add(this.guessBtn);
            this.Controls.Add(this.userInput);
            this.Controls.Add(this.seeIfyouWinLabel);
            this.Controls.Add(this.pickANumLabel);
            this.Name = "Assignment10_Lui";
            this.Text = "GuessANumber";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pickANumLabel;
        private System.Windows.Forms.Label seeIfyouWinLabel;
        private System.Windows.Forms.TextBox userInput;
        private System.Windows.Forms.Button guessBtn;
        private System.Windows.Forms.Button nextGuessBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label hintLabel;
        private System.Windows.Forms.Label hiddenHintsLabel;
        private System.Windows.Forms.Label correctLabel;
        private System.Windows.Forms.Label incorrectLabel;
        private System.Windows.Forms.Label numOfCorrectGuessLabel;
        private System.Windows.Forms.Label numOfIncorrectGuessLabel;
        private System.Windows.Forms.Label winOrLoseMessageLabel;
    }
}


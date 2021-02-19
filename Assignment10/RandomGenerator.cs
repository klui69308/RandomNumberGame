using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment10
{
    //Random Generator Class
    class RandomGenerator
    {
        //A method that returns a random integer array
        public int[] randomIntArrGenerator()
        {
            int[] intArr = new int[100];
            var rand = new Random();
            for (int i = 0; i < 100; i++)
            {
                intArr[i] = rand.Next(100);
            }
            return intArr;
        }
    }
}

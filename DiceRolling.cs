using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission_2
{
    //This is a second class called DiceRolling
    internal class DiceRolling
    {
        //Create a method named Dice with a parameter of userInput
        public int[] Dice(int userInput)
        {
            //create a array for all combination
            int[] combinationCount = new int[11];

            //call random
            Random random = new Random();

            //Rolls the dice numbers of between 1 and 6 for the times the user inputs in the first class
            for (int i = 0; i < userInput; i++)
            {
                int dice1 = random.Next(1, 7);
                int dice2 = random.Next(1, 7);

                //add dice1 and dice2 to get a combination
                int total = dice1 + dice2;

                //store in the array. total-2 because when the total number is 2, the index of combinationCount array is 0
                combinationCount[total - 2]++;
            }

            //Return the array to the first class.
            return combinationCount;
        }
    }
}

//Aiki Takaku Section 3
//Mission 2 Assignment

using System;
using System.Runtime.CompilerServices;

//This is a first class named Program
internal class Program
{
    //This is a method in the Program
    private static void Main()
    {
        //This codes below write a message to user
        System.Console.WriteLine("Welcome to the dice throwing simulator! \n");
        System.Console.Write("How many dice rolls would you like to simulate? ");

        //Create variables hold the values user inputs
        string userInput = Console.ReadLine();

        //If the user input the valid value, do this code below
        if (int.Parse(userInput) > 0)
        {
            //This codes invokes 'Dice' methods from DiceRolling class with userInput as a parameter to pass in the second class
            DiceRolling dicerolling = new DiceRolling();
            int[] combinationCount = dicerolling.Dice(int.Parse(userInput));

            //Display message to user
            System.Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
            System.Console.WriteLine("Each '*' represents 1 % of the total number of rolls.");
            System.Console.WriteLine($"Total number of rolls = {int.Parse(userInput)}\n");

            //For every value in the combinationCount, do the following
            for (int i = 0; i < combinationCount.Length; i++)
            {
                //Create variable called count that return the 1% of total rolls using * as a symbol. Add 2 because the possible combination starts from 2, but not 0
                int count = combinationCount[i] * 100 / int.Parse(userInput);
                Console.WriteLine($"{i + 2}:\t{new string('*', count)}");
            }

            // Display message to the user
            System.Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
        }
    }
}

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
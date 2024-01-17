//Aiki Takaku Section 3
//Mission 2 Assignment!

using Mission_2;
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
            //These do declaration and instantiation
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
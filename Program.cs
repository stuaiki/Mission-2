using System;

internal class Program
{
    private static void Main(string[] args)
    {
        System.Console.WriteLine("Welcome to the dice throwing simulator! \n");
        System.Console.Write("How many dice rolls would you like to simulate? ");

        string userInput = Console.ReadLine();

        if (int.Parse(userInput) > 0)
        {
            DiceRolling dicerolling = new DiceRolling();
            int[] combinationCount = dicerolling.Dice(int.Parse(userInput));

            System.Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
            System.Console.WriteLine("Each '*' represents 1 % of the total number of rolls.");
            System.Console.WriteLine($"Total number of rolls = {int.Parse(userInput)}\n");

            for (int i = 0; i < combinationCount.Length; i++)
            {
                int count = combinationCount[i] * 100 / int.Parse(userInput);
                Console.WriteLine($"{i + 2}:\t{new string('*', count)}");
            }

            System.Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
        }
    }
}

internal class DiceRolling
{
    public int[] Dice(int userInput)
    {
        int[] combinationCount = new int[11];

        Random random = new Random();

        for (int i = 0; i < userInput; i++)
        {
            int dice1 = random.Next(1, 7);
            int dice2 = random.Next(1, 7);

            int total = dice1 + dice2;

            combinationCount[total - 2]++;
        }

        return combinationCount;
    }
}
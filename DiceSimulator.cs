using System;

class DiceSimulator
{
    static void Main()
    {
        Console.WriteLine("Welcome to the dice throwing simulator!");

        Console.Write("How many dice rolls would you like to simulate? ");
        int numberOfRolls = int.Parse(Console.ReadLine());

        DiceRoller diceRoller = new DiceRoller();
        int[] results = diceRoller.SimulateRolls(numberOfRolls);

        Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
        Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");

        for (int iCount = 2; iCount <= 12; iCount++)
        {
            int percentage = results[iCount] * 100 / numberOfRolls;
            string stars = new string('*', percentage);
            Console.WriteLine($"{iCount}: {stars}");
        }

        Console.WriteLine($"Total number of rolls = {numberOfRolls}.");
        Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
    }
}

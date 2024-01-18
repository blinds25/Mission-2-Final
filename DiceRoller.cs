using System;

class DiceRoller
{
    public int[] SimulateRolls(int numberOfRolls)
    {
        int[] results = new int[13]; // Index 0 is not used

        Random random = new Random();

        for (int iCount = 0; iCount < numberOfRolls; iCount++)
        {
            int dice1 = random.Next(1, 7);
            int dice2 = random.Next(1, 7);
            int sum = dice1 + dice2;

            results[sum]++;
        }

        return results;
    }
}

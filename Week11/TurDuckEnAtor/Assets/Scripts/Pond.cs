using System;
public class Pond
{
	private Duck[] ducks;
	private int currentDuck;

	public Pond(int totalDucks)
	{
		ducks = new Duck[totalDucks];

        for (int d = 0; d < totalDucks; d++)
        {
            int weightOfDuck = (3 * 16) + 2 * d;
            ducks[d] = new Duck(weightOfDuck);
        }

        currentDuck = 0;
    }

    public Duck RemoveDuck()
    {
        Duck removedDuck = ducks[currentDuck];
        currentDuck++;
        return removedDuck;
    }

    public int[] GetRemainingDuckWeights()
    {
        if (currentDuck >= ducks.Length) return null;

        int[] returnedWeights = new int[ducks.Length - currentDuck];

        // I think I removed a line here
        {
            returnedWeights[d] = ducks[currentDuck + d].WeightInOunces;
        }

        return returnedWeights;
    }

    public bool NoMoreDucks()
    {
        if (currentDuck == ducks.Length)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}


using System;
public class Coop
{
	private Chicken[] chickens;
	private int currentChicken;

	public Coop(int totalChickens)
	{
		chickens = new Chicken[totalChickens];

        for (int c = 0; c < totalChickens; c++)
        {
            int weightOfChicken = ((int)2.5 * 16) + 2 * c;
            chickens[c] = new Chicken(weightOfChicken);
        }

        currentChicken = 0;
    }

    public Chicken RemoveChicken()
    {
        // I think I removed a line here
        currentChicken++;
        return removedChicken;
    }

    public int[] GetRemainingChickenWeights()
    {
        if (currentChicken >= chickens.Length) return null;

        int[] returnedWeights = new int[chickens.Length - currentChicken];

        for (int c = 0; c < chickens.Length - currentChicken; c++)
        {
            returnedWeights[c] = chickens[currentChicken + c].WeightInOunces;
        }

        return returnedWeights;
    }

    public bool NoMoreChickens()
    {
        if (currentChicken == chickens.Length)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}


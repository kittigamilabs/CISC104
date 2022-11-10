using System;
public class Forest
{
	private Turkey[] turkeys;
	private int currentTurkey;

	public Forest(int totalTurkeys)
	{
		turkeys = new Turkey[totalTurkeys];

		for(int t = 0; t < totalTurkeys; t++)
        {
			int weightOfTurkey = (14 * 16) + 3 * t;
			turkeys[t] = new Turkey(weightOfTurkey);
        }

		currentTurkey = 0;
	}

	public Turkey RemoveTurkey()
    {
		Turkey removedTurkey = turkeys[currentTurkey];
		currentTurkey++;
		return removedTurkey;
    }

	public int[] GetRemainingTurkeyWeights()
    {
		if (currentTurkey >= turkeys.Length) return null;

		int[] returnedWeights = new int[turkeys.Length - currentTurkey];

		for(int t = 0; t < turkeys.Length - currentTurkey; t++)
        {
            // I think I removed a line here
        }

        return returnedWeights;
    }

	public bool NoMoreTurkeys()
    {
		if (currentTurkey == turkeys.Length)
		{
			return true;
		}
		else
        {
			return false;
        }
    }
}


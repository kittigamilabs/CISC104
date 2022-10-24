﻿using System;
public class PlayerOne
{
	// Success rate of hitting a bullseye with no distraction.
	// An integer value between 1 and 100.
	// A higher value makes it more difficult to hit a bullseye
	private int naturalSuccessRate = 75;

	// The amount of distraction provided by another player.
	private int amountOfDistraction = 0;

    public int BullsEyes { get; set; }

    private bool DistractedSomeone = false;

	public PlayerOne()
	{
	}

	public bool HitBullseye()
    {
		Random rng = new Random();

		int successRoll = rng.Next(100);

		if(successRoll >= (naturalSuccessRate + amountOfDistraction))
        {
			return true;
        }
        else
        {
            return false;
        }
    }

    public void DistractPlayerTwo(PlayerTwo playerTwo)
    {
        if (!DistractedSomeone)
        {
            playerTwo.GetDistracted(50);
            DistractedSomeone = true;
        }
    }

    public void GetDistracted(int newAmountOfDistraction)
    {
		amountOfDistraction = newAmountOfDistraction;
    }

	public void NewRound()
	{
		amountOfDistraction = 0;
        DistractedSomeone = false;
	}

    public void NewGame()
    {
        amountOfDistraction = 0;
        DistractedSomeone = false;
        BullsEyes = 0;
    }

    public int GetScoreToBeat()
    {
        return naturalSuccessRate + amountOfDistraction;
    }
}

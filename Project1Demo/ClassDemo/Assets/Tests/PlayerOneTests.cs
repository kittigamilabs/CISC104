using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class PlayerOneTests
{
    // Test the default constructor for Player One
    [Test]
    public void PlayerOneConstructorTest()
    {
        // Setup and Act
        PlayerOne newPlayerOne = new PlayerOne();

        // Assert
        Assert.AreEqual(0, newPlayerOne.BullsEyes);
        Assert.AreEqual(75, newPlayerOne.GetScoreToBeat());
    }

    // Test Distracting Player Two
    [Test]
    public void DistractPlayerTwoTest()
    {
        // Setup
        PlayerOne newPlayerOne = new PlayerOne();
        PlayerTwo newPlayerTwo = new PlayerTwo();
        int playerTwoNaturalScore = newPlayerTwo.GetScoreToBeat();

        // Act
        newPlayerOne.DistractPlayerTwo(newPlayerTwo);

        // Assert
        Assert.AreEqual(playerTwoNaturalScore + 50, newPlayerTwo.GetScoreToBeat());
    }

    // Test Distracting Player Two only occurs once
    [Test]
    public void DistractPlayerTwoOnlyOnce()
    {
        // Setup
        PlayerOne newPlayerOne = new PlayerOne();
        PlayerTwo newPlayerTwo = new PlayerTwo();
        int playerTwoNaturalScore = newPlayerTwo.GetScoreToBeat();

        // Act
        newPlayerOne.DistractPlayerTwo(newPlayerTwo);
        newPlayerOne.DistractPlayerTwo(newPlayerTwo);

        // Assert
        Assert.AreEqual(playerTwoNaturalScore + 50, newPlayerTwo.GetScoreToBeat());
    }

    // Test New Game method resets values of Player One to default
    [Test]
    public void NewGameTest()
    {
        // Setup new Player One
        PlayerOne newPlayerOne = new PlayerOne();
        PlayerTwo newPlayerTwo = new PlayerTwo();

        // Act
        for(int i = 1; i < 100; i++)
        {
            // Player Two Distracts Player One
            newPlayerTwo.DistractPlayerOne(newPlayerOne);

            // Players One and Two Tries To Throw A Bullseye
            newPlayerOne.HitBullseye();
            newPlayerTwo.HitBullseye();
        }

        // Should reset all the values of Player One
        newPlayerOne.NewGame();

        // Assert
        Assert.AreEqual(0, newPlayerOne.BullsEyes);
        Assert.AreEqual(75, newPlayerOne.GetScoreToBeat());
    }

    // Test HitBullseye Method
    [Test]
    public void TestHitBullseye()
    {
        PlayerOne newPlayerOne = new PlayerOne();
        int calculatedBullseyes = 0;

        for(int i = 0; i < 100; i++)
        {
            if(newPlayerOne.HitBullseye())
            {
                // Hit the bullseye
                calculatedBullseyes++;
            }
            else
            {
                // Missed the bullseye
            }

            Assert.AreEqual(calculatedBullseyes, newPlayerOne.BullsEyes);
        }
    }
}

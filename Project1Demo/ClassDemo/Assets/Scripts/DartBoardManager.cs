using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DartBoardManager : MonoBehaviour
{
    private PlayerOne playerOne;
    private PlayerTwo playerTwo;

    private int roundNumber = 0;

    public GameObject playerOneBullsEyeCount;
    public GameObject playerOneToHit;

    private TextMeshProUGUI playerOneBullseyeText;
    private TextMeshProUGUI playerOneToHitText;

    public GameObject playerTwoBullsEyeCount;
    public GameObject playerTwoToHit;

    private TextMeshProUGUI playerTwoBullseyeText;
    private TextMeshProUGUI playerTwoToHitText;

    public GameObject currentRoundGameObject;

    private TextMeshProUGUI currentRoundText;

    // Start is called before the first frame update
    void Start()
    {
        playerOne = new PlayerOne();
        playerTwo = new PlayerTwo();

        playerOneBullseyeText = playerOneBullsEyeCount.GetComponent<TextMeshProUGUI>();
        playerOneToHitText = playerOneToHit.GetComponent<TextMeshProUGUI>();

        playerTwoBullseyeText = playerTwoBullsEyeCount.GetComponent<TextMeshProUGUI>();
        playerTwoToHitText = playerTwoToHit.GetComponent<TextMeshProUGUI>();

        currentRoundText = currentRoundGameObject.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        playerOneBullseyeText.text = "Bullseyes: " + playerOne.BullsEyes.ToString();
        playerOneToHitText.text = "Score To Hit: " + playerOne.GetScoreToBeat().ToString();

        playerTwoBullseyeText.text = "Bullseyes: " + playerTwo.BullsEyes.ToString();
        playerTwoToHitText.text = "Score To Hit: " + playerTwo.GetScoreToBeat().ToString();

        currentRoundText.text = "Current Round: " + roundNumber.ToString();
    }

    public void CalculateRoundResults()
    {
        // Call functions and move logic into separate classes.
        playerOne.HitBullseye();
        playerTwo.HitBullseye();

        roundNumber++;
    }

    public void PlayerOneDistractsPlayerTwo()
    {
        playerOne.DistractPlayerTwo(playerTwo);
    }

    public void PlayerTwoDistractsPlayerOne()
    {
        playerTwo.DistractPlayerOne(playerOne);
    }

    public void NewGame()
    {
        playerOne.NewGame();
        playerTwo.NewGame();

        roundNumber = 0;
    }
}

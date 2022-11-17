using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CardManager : MonoBehaviour
{
    public Card[] cards;

    public RawImage currentCardImage;

    private int currentCardIndex;

    public GameObject cardTextGameObject;

    private TextMeshProUGUI cardText;

    // Start is called before the first frame update
    void Start()
    {
        currentCardIndex = 0;

        cardText = cardTextGameObject.GetComponent<TextMeshProUGUI>();

        SetImage();
    }

    public void PreviousCard()
    {
        if(currentCardIndex == 0)
        {
            currentCardIndex = cards.Length - 1;
        }
        else
        {
            currentCardIndex--;
        }

        SetImage();
    }

    public void NextCard()
    {
        if (currentCardIndex == cards.Length - 1)
        {
            currentCardIndex = 0;
        }
        else
        {
            currentCardIndex++;
        }

        SetImage();
    }

    private void SetImage()
    {
        // For debugging and seeing card information without image
        cardText.text = cards[currentCardIndex].cardName;

        if (cards[currentCardIndex].cardImage != null)
        {
            currentCardImage.texture = cards[currentCardIndex].cardImage.texture;
        }
        else
        {
            currentCardImage.texture = null;
        }
    }
}

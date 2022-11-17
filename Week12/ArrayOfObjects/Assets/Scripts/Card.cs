using System;
using UnityEngine;
using UnityEngine.UI;

public enum CardSuit
{
    Club,
    Penguin,
    Bob,
    Puffle
}

public class Card : MonoBehaviour
{
    // The name of this card
    public String cardName;

    // The image for this card
    public RawImage cardImage;

    // The relative size or value of this card
    public int bigness;

    // The suit for this card
    public CardSuit cardSuit;
}


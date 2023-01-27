using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDatabase : MonoBehaviour
{
    public List<Sprite> myCards;
    public static List<Card> cardList = new List<Card>();
    List<string> cardNames = new List<string>()
        {
    "ace_of_clubs", "ten_of_clubs", "king_of_clubs", "queen_of_clubs", "jack_of_clubs",
    "ace_of_diamonds", "ten_of_diamonds", "king_of_diamonds", "queen_of_diamonds", "jack_of_diamonds",
    "ace_of_hearts", "ten_of_hearts", "king_of_hearts", "queen_of_hearts", "jack_of_hearts",
    "ace_of_spades", "ten_of_spades", "king_of_spades", "queen_of_spades", "jack_of_spades"
        };

    void Awake()
    {
        for (int i = 0; i < cardNames.Count; i++)
        {
            //cardList.Add(new Card((i + 1), cardNames[i],  , GetCardValue(cardNames[i])));
        }
    }
    


    public static int GetCardValue(string cardName)
    {
        int cardValue;
        switch (cardName)
        {
            case "ace_of_clubs":
            case "ace_of_diamonds":
            case "ace_of_hearts":
            case "ace_of_spades":
                cardValue = 11;
                break;
            case "ten_of_clubs":
            case "ten_of_diamonds":
            case "ten_of_hearts":
            case "ten_of_spades":
                cardValue = 10;
                break;
            case "king_of_clubs":
            case "king_of_diamonds":
            case "king_of_hearts":
            case "king_of_spades":
                cardValue = 4;
                break;
            case "queen_of_clubs":
            case "queen_of_diamonds":
            case "queen_of_hearts":
            case "queen_of_spades":
                cardValue = 3;
                break;
            case "jack_of_clubs":
            case "jack_of_diamonds":
            case "jack_of_hearts":
            case "jack_of_spades":
                cardValue = 2;
                break;
            default:
                throw new ArgumentException("Invalid card name");
        }
        return cardValue;
    }
}

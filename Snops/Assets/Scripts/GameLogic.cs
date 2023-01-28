using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLogic
{
    public int GameScore;


    public static bool CheckRoundWinner()
    {
        return false;
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

    public static string GetSuit(string cardName)
    {
        string output = cardName.Substring(cardName.LastIndexOf("_") + 1);
        return output;
    }
    public static bool IsTrumpCard(Card card1, string trumpSuit)
    {
        if (GetSuit(card1.Name) == trumpSuit)
        {
            return true;
        }
        return false;
    }
}

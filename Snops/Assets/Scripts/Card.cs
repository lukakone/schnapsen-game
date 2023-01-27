using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]

public class Card
{

    public int id;
    public string cardName;
    public Sprite source;
    public int value;

    public Card() { }

    public Card(int Id, string CardName, Sprite Source, int Value)
    {
        id = Id;
        cardName = CardName;
        source = Source;
        value = Value;
    }
}

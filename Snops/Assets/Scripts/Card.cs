using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]

public class Card
{
    public int id;
    public string name;
    public Sprite source;
    public int value;

    public Card() { }

    public int Id
    {
        get { return id; }
        set { id = value; }
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public Sprite Source
    {
        get { return source; }
        set { source = value; }
    }

    public int Value
    {
        get { return value; }
        set { this.value = value; }
    }
    public Card(int Id, string Name, Sprite Source, int Value)
    {
        id = Id;
        name = Name;
        source = Source;
        value = Value;
    }
}

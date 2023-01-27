using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class CardScript : MonoBehaviour
{
    static int x = 750;
    static int counter = 0;
    static List<GameObject> midCards = new List<GameObject>();

    public GameObject myCard;
    private void OnMouseDown()
    {
        GameObject parent = myCard.transform.parent.gameObject;
        if (counter == 4)
        {
            x = 750;
            counter = 0;
            foreach(var card in midCards)
            {
                card.transform.position = new Vector3(1700, 900, 0);
            }
        }
        if (parent.name == "Player2Area" || parent.name == "Player3Area" || parent.name == "Player4Area")
        {
            myCard.transform.position = new Vector3(x, 600, 0);
            myCard.transform.localScale = new Vector3(3,3,0);
            if(parent.name == "Player2Area" || parent.name == "Player4Area")
            {
                myCard.transform.Rotate(Vector3.forward, -90f);
            }
            midCards.Add(myCard);
            x += 80;
            counter++;
            
        }
        else
        {
            myCard.transform.position = new Vector3(x, 600, 0);
            midCards.Add(myCard);
            x += 80;
            counter++;
        }
        
        
    }
}

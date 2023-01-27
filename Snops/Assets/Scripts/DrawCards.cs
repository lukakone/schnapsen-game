using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DrawCards : MonoBehaviour
{
    public List<Sprite> myCards;
    public GameObject Card;
    public GameObject Player1Area;
    public GameObject Player2Area;
    public GameObject Player3Area;
    public GameObject Player4Area;


    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            GameObject player1Card = Instantiate(Card, new Vector3(0, 0, 0), Quaternion.identity);
            player1Card.transform.SetParent(Player1Area.transform, false);
            Sprite card1 = getRandomCard();
            player1Card.GetComponent<Image>().sprite = card1;
            
            GameObject player2Card = Instantiate(Card, new Vector3(0, 0, 0), Quaternion.identity);
            player2Card.transform.SetParent(Player2Area.transform, false);
            Sprite card2 = getRandomCard();
            player2Card.GetComponent<Image>().sprite = card2;

            GameObject player3Card = Instantiate(Card, new Vector3(0, 0, 0), Quaternion.identity);
            player3Card.transform.SetParent(Player3Area.transform, false);
            Sprite card3 = getRandomCard();
            player3Card.GetComponent<Image>().sprite = card3;

            GameObject player4Card = Instantiate(Card, new Vector3(0, 0, 0), Quaternion.identity);
            player4Card.transform.SetParent(Player4Area.transform, false);
            Sprite card4 = getRandomCard();
            player4Card.GetComponent<Image>().sprite = card4;

            /*if (i == 0)
            {
                player1Card.transform.rotation = Quaternion.Euler(Vector3.forward * 20);

            }
            else if(i == 1)
            {
                player1Card.transform.rotation = Quaternion.Euler(Vector3.forward * 10);
            }
            else if(i == 3)
            {
                player1Card.transform.rotation = Quaternion.Euler(Vector3.forward * -10);
            }
            else if (i == 4)
            {
                player1Card.transform.rotation = Quaternion.Euler(Vector3.forward * -20);
            }*/
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Sprite getRandomCard()
    {
        int min = 0;
        int max = myCards.Count;
        Sprite card;
        System.Random random = new System.Random();
        int randomNumber = random.Next(min, max);
        card = myCards[randomNumber];
        myCards.RemoveAt(randomNumber);
        return card;
    }


}

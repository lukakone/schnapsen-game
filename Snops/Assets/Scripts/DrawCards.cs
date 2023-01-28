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
    public List<KeyValuePair<Card, GameObject>> Player1Cards = new List<KeyValuePair<Card, GameObject>>();
    public List<KeyValuePair<Card, GameObject>> Player2Cards = new List<KeyValuePair<Card, GameObject>>();
    public List<KeyValuePair<Card, GameObject>> Player3Cards = new List<KeyValuePair<Card, GameObject>>();
    public List<KeyValuePair<Card, GameObject>> Player4Cards = new List<KeyValuePair<Card, GameObject>>();


    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            //Player 1 card
            Sprite getCard1 = GetRandomCard();
            Card card1 = new Card(i, getCard1.name, getCard1, GameLogic.GetCardValue(getCard1.name));
            GameObject player1Card = Instantiate(Card, new Vector3(0, 0, 0), Quaternion.identity);
            player1Card.GetComponent<Image>().sprite = card1.Source;
            player1Card.transform.SetParent(Player1Area.transform, false);
            Player1Cards.Add(new KeyValuePair<Card, GameObject>(card1, player1Card));
            //Player 2 card
            Sprite getCard2 = GetRandomCard();
            Card card2 = new Card(i, getCard2.name, getCard2, GameLogic.GetCardValue(getCard2.name));
            GameObject player2Card = Instantiate(Card, new Vector3(0, 0, 0), Quaternion.identity);
            player2Card.GetComponent<Image>().sprite = card2.Source;
            player2Card.transform.SetParent(Player2Area.transform, false);
            Player2Cards.Add(new KeyValuePair<Card, GameObject>(card2, player2Card));

            //Player 3 card
            Sprite getCard3 = GetRandomCard();
            Card card3 = new Card(i, getCard3.name, getCard3, GameLogic.GetCardValue(getCard3.name));
            GameObject player3Card = Instantiate(Card, new Vector3(0, 0, 0), Quaternion.identity);
            player3Card.GetComponent<Image>().sprite = card3.Source;
            player3Card.transform.SetParent(Player3Area.transform, false);
            Player3Cards.Add(new KeyValuePair<Card, GameObject>(card3, player3Card));


            //Player 4 card
            Sprite getCard4 = GetRandomCard();
            Card card4 = new Card(i, getCard4.name, getCard4, GameLogic.GetCardValue(getCard4.name));
            GameObject player4Card = Instantiate(Card, new Vector3(0, 0, 0), Quaternion.identity);
            player4Card.GetComponent<Image>().sprite = card4.Source;
            player4Card.transform.SetParent(Player4Area.transform, false);
            Player4Cards.Add(new KeyValuePair<Card, GameObject>(card4, player4Card));

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
            print("Player 1\n");
            print(KeyValuePairToString(Player1Cards));
            print("Player 2\n");
            print(KeyValuePairToString(Player2Cards));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Sprite GetRandomCard()
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
    public string KeyValuePairToString(List<KeyValuePair<Card, GameObject>> Cards)
    {
        string cardListString = "";
        foreach (var card in Cards)
        {
            cardListString += "Card: " + card.Key.Name + ", GameObject: " + card.Value.name + "\n";
        }
        return cardListString;
    }

}

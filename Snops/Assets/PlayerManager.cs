using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class PlayerManager : NetworkBehaviour
{
    public List<GameObject> cards;
    public GameObject PlayerArea;
    //public GameObject EnemyArea;

    public GameObject EnemyArea1;
    public GameObject EnemyArea2;
    public GameObject EnemyArea3;

    public GameObject DropArea;

    public override void OnStartClient()
    {
        base.OnStartClient();

        PlayerArea = GameObject.Find("PlayerArea");
        //EnemyArea = GameObject.Find("EnemyArea");

        EnemyArea1 = GameObject.Find("EnemyArea1");
        EnemyArea2 = GameObject.Find("EnemyArea2");
        EnemyArea3 = GameObject.Find("EnemyArea3");


        DropArea = GameObject.Find("DropArea");
        
    }


    [Command]
    public void CmdDealCards()
    {
        for (int i = 0; i < 5; i++)
        {
            GameObject card = Instantiate(cards[Random.Range(0, cards.Count)], new Vector2(0, 0), Quaternion.identity);
            NetworkServer.Spawn(card, connectionToClient);
            RpcShowCard(card, "Dealt");
        }
    }



    public void PlayCard(GameObject card)
    {
        CmdPlayCard(card);
    }

    [Command]
    void CmdPlayCard(GameObject card)
    {
        RpcShowCard(card, "Played");
    }


    [ClientRpc]
    void RpcShowCard(GameObject card, string type)
    {
        if (type == "Dealt")
        {
            if (isOwned)
            {
                card.transform.SetParent(PlayerArea.transform, false);
            }
            else if (NetworkServer.active)
            {
                if (EnemyArea1.transform.childCount < 5)
                {
                    card.transform.SetParent(EnemyArea1.transform, false);
                    card.GetComponent<CardFlipper>().Flip();
                }
                else
                {
                    if (EnemyArea2.transform.childCount < 5)
                    {
                        card.transform.SetParent(EnemyArea2.transform, false);
                        card.GetComponent<CardFlipper>().Flip();
                    }
                    else
                    {
                        card.transform.SetParent(EnemyArea3.transform, false);
                        card.GetComponent<CardFlipper>().Flip();
                    }
                }
            }
            else
            {
                PlayerManager pm = NetworkClient.connection.identity.GetComponent<PlayerManager>();
                switch (pm.netId)
                {
                    case 9:
                        if (EnemyArea3.transform.childCount < 5)
                        {
                            card.transform.SetParent(EnemyArea3.transform, false);
                            card.GetComponent<CardFlipper>().Flip();
                        }
                        else
                        {
                            if (EnemyArea1.transform.childCount < 5)
                            {
                                card.transform.SetParent(EnemyArea1.transform, false);
                                card.GetComponent<CardFlipper>().Flip();
                            }
                            else
                            {
                                card.transform.SetParent(EnemyArea2.transform, false);
                                card.GetComponent<CardFlipper>().Flip();
                            }
                        }
                        break;
                    case 10:
                        if (EnemyArea2.transform.childCount < 5)
                        {
                            card.transform.SetParent(EnemyArea2.transform, false);
                            card.GetComponent<CardFlipper>().Flip();
                        }
                        else
                        {
                            if (EnemyArea3.transform.childCount < 5)
                            {
                                card.transform.SetParent(EnemyArea3.transform, false);
                                card.GetComponent<CardFlipper>().Flip();
                            }
                            else
                            {
                                card.transform.SetParent(EnemyArea1.transform, false);
                                card.GetComponent<CardFlipper>().Flip();
                            }
                        }
                        break;
                    case 11:
                        if (EnemyArea1.transform.childCount < 5)
                        {
                            card.transform.SetParent(EnemyArea1.transform, false);
                            card.GetComponent<CardFlipper>().Flip();
                        }
                        else
                        {
                            if (EnemyArea2.transform.childCount < 5)
                            {
                                card.transform.SetParent(EnemyArea2.transform, false);
                                card.GetComponent<CardFlipper>().Flip();
                            }
                            else
                            {
                                card.transform.SetParent(EnemyArea3.transform, false);
                                card.GetComponent<CardFlipper>().Flip();
                            }
                        }
                        break;
                    default:    
                        break;
                }

            }
        }
        else if (type == "Played")
        {
            card.transform.SetParent(DropArea.transform, false);
            if (!isOwned)
            {
                card.GetComponent<CardFlipper>().Flip();
            }
        }
    }


    
}

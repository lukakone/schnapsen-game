using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class DealCards : NetworkBehaviour
{
    public PlayerManager PlayerManager;

    private bool dealCards = false;
    [SyncVar]
    public int playersConnected;

    public void OnClick()
    {
        NetworkIdentity networkIdentity = NetworkClient.connection.identity;
        PlayerManager = networkIdentity.GetComponent<PlayerManager>();
        PlayerManager.CmdDealCards();
    }
}

using Photon.Pun;
using UnityEngine;

public class SpawnPlayers : MonoBehaviour
{
    public GameObject playerPrefab;
    public Transform[] spawnPoints;
    public PhotonView photonView;

    private void Start()
    {
        PhotonNetwork.Instantiate(playerPrefab.name, new Vector2(0,0), Quaternion.identity, (byte)photonView.ViewID);
    }
}

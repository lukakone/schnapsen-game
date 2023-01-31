using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;


public class TestNetworkButtons : MonoBehaviour
{
    void OnGUI()
    {
        GUILayout.BeginArea(new Rect(100, 100, 300, 300));
        if(!NetworkManager.Singleton.IsClient && !NetworkManager.Singleton.IsServer)
        {
            if (GUILayout.Button("Host")) NetworkManager.Singleton.StartHost();
            if (GUILayout.Button("Server")) NetworkManager.Singleton.StartServer();
            if (GUILayout.Button("Client")) NetworkManager.Singleton.StartClient();
        }

        GUILayout.EndArea();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;

public class TestCardScript : NetworkBehaviour
{
    static int x = -5;
    private void Start()
    {
        gameObject.transform.position = new Vector2(0, 0);
    }

    public void OnMouseDown()
    {
        gameObject.transform.position = new Vector2(x, 0);
        x += 2;
    }

}

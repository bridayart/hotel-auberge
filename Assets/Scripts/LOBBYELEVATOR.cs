using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LOBBYELEVATOR : MonoBehaviour
{
    public Transform LOBBYELE;
    public GameObject Mainplayer;

    private void OnTriggerEnter(Collider other)
    {
        Mainplayer.transform.position = LOBBYELE.transform.position;
    }

}

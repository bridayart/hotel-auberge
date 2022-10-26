using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleportkitchenlobby : MonoBehaviour
{
    public Transform LOBBYKITCH;
    public GameObject Mainplayer;

    private void OnTriggerEnter(Collider other)
    {
        Mainplayer.transform.position = LOBBYKITCH.transform.position;
    }

}

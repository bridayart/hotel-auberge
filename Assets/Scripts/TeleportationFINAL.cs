using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportationFINAL : MonoBehaviour
{
    public Transform LOBBYBR;
    public GameObject Mainplayer;

    private void OnTriggerEnter(Collider other)
    {
        Mainplayer.transform.position = LOBBYBR.transform.position;
    }

}

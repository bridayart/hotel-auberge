using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BRTOLOBBY : MonoBehaviour
{
    public Transform BRLOBBY;
    public GameObject Mainplayer;

    private void OnTriggerEnter(Collider other)
    {
        Mainplayer.transform.position = BRLOBBY.transform.position;
    }

}

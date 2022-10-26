using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KitchentoLobbytele : MonoBehaviour
{
    public Transform KITCHLOBBY;
    public GameObject Mainplayer;

    private void OnTriggerEnter(Collider other)
    {
        Mainplayer.transform.position = KITCHLOBBY.transform.position;
    }

}

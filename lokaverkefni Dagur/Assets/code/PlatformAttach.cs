using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformAttach : MonoBehaviour
{
    public Rigidbody rb;
    public GameObject Player;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == Player)
        {
            Player.transform.parent = transform;
            rb.freezeRotation = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {

        if (other.gameObject == Player)
        {
            Player.transform.parent = null;
        }

    }


}

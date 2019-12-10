using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(90 * Time.deltaTime, 0, 0); //rotates the coin
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "Player")
        {
            FindObjectOfType<AudioManager>().Play("Pickup_Coin18"); // plays sound
            // add 1 to points
            other.GetComponent<PlayerScript>().coins++;
            Destroy(gameObject); // this destroys things
        }
    }
}

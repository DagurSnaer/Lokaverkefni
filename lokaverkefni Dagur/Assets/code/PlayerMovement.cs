using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    // við köllum rigidbody rb
    public Rigidbody rb;

    public float forwardForce = 500f;

    public float sidewaysForce = 500f;

    public float jumpVelocity = 7f;

    public bool isOnGround; 



    void Start() // enables isOnGround at the start
    {
        isOnGround = true;
        
    }

    
    void Update() {

        // checks to see if the player is on the ground and if the user pressed space
        if (isOnGround && Input.GetButtonDown("Jump"))
        {
            // makes the player jump and turns isOnGround to false
            GetComponent<Rigidbody>().velocity = Vector3.up * jumpVelocity;
            FindObjectOfType<AudioManager>().Play("Jump18"); // plays jump sound
            isOnGround = false;
        }
    }

    // we marked this as fixedupdate because we are using it to mess with physiscs
    void FixedUpdate ()
    {

        if ( Input.GetKey("d")) // if the player is pressing the d key
        {
            // add a force to the right 
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        
        if (Input.GetKey("a")) // if the player is pressing the a key
        {
            // add a force to the left
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("w")) // if the player is pressing the w key
        {
            // add a force forward
            rb.AddForce(0, 0, forwardForce * Time.deltaTime, ForceMode.VelocityChange);
        }

        if (Input.GetKey("s")) // if the player is pressing the s key
        {
            // add a force backwards
            rb.AddForce(0, 0, -forwardForce * Time.deltaTime, ForceMode.VelocityChange);
        }
        // if the player falls below y pos -1
        if (rb.position.y < -1f)
        {
            // goes to EndGame
            FindObjectOfType<GameManager>().EndGame();
        }

    }
}

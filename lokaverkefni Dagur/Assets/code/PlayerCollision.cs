using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public PlayerMovement movement; // a reference to playermovememnt
    bool isOnGround;

    // this function runs when we hit another object
    // we get information about the collision and call it collisioninfo
    void OnCollisionEnter( Collision collisionInfo)
    {
        // we check if the object we collided with has a tag called obstacle
        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false; // disable the players movement
            FindObjectOfType<GameManager>().EndGame();
        }

        // checks to see if player touched something with the tag Ground and enables isOnGround if it does
        if (collisionInfo.gameObject.CompareTag("Ground"))
        {
            movement.isOnGround = true;
        }
    }

}


using UnityEngine;

public class PlayerCollision : MonoBehaviour
{


    public PlayerMovement movement;
    
    public GameManager gameManager;

    // Update is called once per frame
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle") 
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        
        }
    }
}

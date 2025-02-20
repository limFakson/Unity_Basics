using UnityEngine;

public class PlayerCollisionScript : MonoBehaviour
{
    public PlayerScript movement;

    void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Obstacle")
        {
            movement.enabled = false;  // Disable the player movement
            Object.FindFirstObjectByType<GameManager>().EndGame();           
        }
    }
}

using UnityEngine;

public class PlayerCollisionScript : MonoBehaviour
{
    public PlayerScript movement;

    void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Obstacle")
        {
            movement.rb.AddForce(0, 0, -200 * movement.speed / 2 * Time.deltaTime);
            Debug.Log("Collision with obstacle");
        }
    }
}

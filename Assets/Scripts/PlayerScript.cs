using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerScript : MonoBehaviour
{
    public Rigidbody rb;
    public float speed = 2.0f;

     void Start()
    {
    }
    void FixedUpdate()
    {
        rb.AddForce(0, 0, 300 * speed * Time.deltaTime);

        // if (Keyboard.current.wKey.isPressed)
        // {
        //     rb.AddForce(0, 0, 1000 * speed * Time.deltaTime);
        // }
        // if(Keyboard.current.sKey.isPressed)
        // {
        //     rb.AddForce(0, 0, -1000 * speed * Time.deltaTime);
        // }
        if(Keyboard.current.aKey.isPressed)
        {
            rb.AddForce(-50  * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if(Keyboard.current.dKey.isPressed)
        {
            rb.AddForce(50 * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        // if(Keyboard.current.spaceKey.isPressed)
        // {
        //     rb.AddForce(0, 500 * speed * Time.deltaTime, 0);
        // }

        if(rb.position.y < -1f)
        {
            Object.FindFirstObjectByType<GameManager>().EndGame();
        }
    }
}

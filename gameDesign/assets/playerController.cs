using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    
    public float maxSpeed;
    public float acceleration;
    public float jumpForce;

    private Rigidbody2D rb;
    private Vector2 direction;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        // Declaring direction variable
        direction = new Vector2(0, 0);

        // If Rigidbody's current speed is less than max speed...
        if (rb.velocity.x < maxSpeed)
        {
            // Add acceleration to the direction's x-component 
            direction.x = acceleration;
        }

        // If the jump button is pressed down...
        if (Input.GetButton("Jump"))
        {
            //_______________________________
            // Add jumpForce to the direction's y-component
            

            //_______________________________
        }

        // Applying directional force to Ribidbody
        rb.AddForce(direction);
    }
}

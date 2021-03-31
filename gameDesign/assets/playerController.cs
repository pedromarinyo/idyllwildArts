using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    // Public Variables
    public float speed;                     // The player's horizontal speed
    public float jumpForce;                 // How high the player jumps
    public LayerMask groundLayer;           // What objects the game considers as "ground"

    private Rigidbody2D rb;                 // The player's rigidBody component, which controls physics
    private Collider2D col;                 // The player's collider, which determines its boundaries
    public bool isGrounded;                 // A variable that keeps track of whether hte player is on the ground
    private float distanceToGround;         // The distance from the player's center to its bottom boundary
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();           // A variable that stores the player's rigidBody
        col = GetComponent<Collider2D>();           // A variable that stores the player's collider
        distanceToGround = col.bounds.extents.y;    // Calcluating the distance from the player's center to the bottom of its collider
    }

    // Update is called once per frame
    void Update()
    {
        // Horizontal Movement
        Vector2 velocity = new Vector2(Input.GetAxis("Horizontal") * speed, 0);     // Reading the player's input to determine movemenet direction
        rb.AddForce(velocity);                                                      // Adding a movement force to the player

        // Jump        
        if (Input.GetButton("Jump"))
        {
            // Sending a line from the player's position to it's feet to calculate if its standing on "ground"
            isGrounded = Physics2D.Raycast(transform.position, Vector3.down, distanceToGround + 0.1f, groundLayer).collider;

            // If the player is standing on ground, apply the vertical jump force
            if (isGrounded) { rb.AddForce(new Vector2(0, jumpForce)); }            
        }
    }
}

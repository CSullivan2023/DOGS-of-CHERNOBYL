using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
    public GameObject groundchecker;
    public LayerMask whatIsGround;

    public float maxSpeed = 10.0f;
    bool isOnGround = false;

    // Ablew to manipulate the body
    Rigidbody2D playerobject;
    // Start is called before the first frame update
    void Start()
    {
        //Attaches Code to body
        playerobject = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        // Horizontal and Vertical input
        float movementValueX = Input.GetAxis("Horizontal");


        //Velocity
        playerobject.velocity = new Vector2(movementValueX * maxSpeed, playerobject.velocity.y);

        //Check to see if the ground check if object is touching ground
        isOnGround = Physics2D.OverlapCircle(groundchecker.transform.position, 1.0f, whatIsGround); 

        if (Input.GetKeyDown(KeyCode.Space) && isOnGround == true)
        {
            playerobject.AddForce(new Vector2(0.0f, 400.0f));
        }
    }     
}
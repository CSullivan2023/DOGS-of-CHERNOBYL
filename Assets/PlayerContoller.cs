using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContoller : MonoBehaviour
{
    public GameObject groundChecker;
    float maxSpeed = 5.0f;

    // Start is called before the first frame update
    Rigidbody2D playerObject;

    //Start is called before the firstframe update
    void Start()
    {
        //Find the Rigidbody2D component that is attached to the same object as this script
        playerObject = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //Create a 'float' that will be equal to the players horizontal input 
        float movementValueX = Input.GetAxis("horizontal");

        //Change the X velocity of the Rigidbody2D to be equal to the movement value 
        playerObject.velocity = new Vector2(movementValueX*10, playerObject.velocity.y);
    }
}

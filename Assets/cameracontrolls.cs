using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameracontrolls : MonoBehaviour
{
    //create a public reference to the player - we will assign this using the unity editor
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //change our position relative to the players position
        transform.position = new Vector3(player.transform.position.x, transform.position.y, transform.position.z);
    }
}

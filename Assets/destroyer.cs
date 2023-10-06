using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyer : MonoBehaviour
{
    //much like like thew ()Start and ()update methods, onTriggerEnter2D is special unity method that is called
    //by unity automatically at a specific point- in this case, when something enters the Trigger attached 
    //to this game 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //if the gameobject that has collided with our trigger is tagged with cleanup...
       if (collision.gameObject.tag == "CleanUp")
        {
            //then we use this method to destory it 
            Destroy(collision.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

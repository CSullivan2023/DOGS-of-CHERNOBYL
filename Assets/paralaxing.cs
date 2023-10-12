using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paralaxing : MonoBehaviour
{
    private float lengh, startpos;
    public GameObject cam;
    public float ParallaxEffect;

    void Start()
    {
        startpos = transform.position.x;
        lengh = GetComponent<SpriteRenderer>().bounds.size.x;
        
    }

   
    void Update()
    {
        float temp = (cam.transform.position.x * (1 - ParallaxEffect));
        float dist = (cam.transform.position.x * ParallaxEffect);

        transform.position = new Vector3(startpos + dist, transform.position.y, transform.position.z);

        if (temp < startpos + lengh)
        
    }
}

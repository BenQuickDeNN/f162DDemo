using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopBackground : MonoBehaviour
{

    //Move Speed;  
    private float mSpeed = 3.0F;
    void Start()
    {

    }
    void Update()
    {
        //Translate form right to left  
        transform.Translate(Vector3.right * Time.deltaTime * mSpeed);
        // If first background is out of camera view,then show sencond background  
        if (transform.position.x <= -11.8F)
        {
            //We can chenge this value to reduce the wdith between 2 background  
            transform.position = new Vector3(-1F, transform.position.y, transform.position.z);
        }
    }
}

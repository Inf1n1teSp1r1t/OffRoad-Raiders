using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(-0.7f, -0.8f, 0) * Time.deltaTime * 3f);
        //if object leaves the screen vertically, destroy it
        if (transform.position.y < -6.5f)  
        {
            Destroy(this.gameObject);
        }
        //if object leaves the screen horizontally, destroy it
        if(transform.position.x > 9.5f || transform.position.x <= -9.5f)
        {
            Destroy(this.gameObject);
        }
    }
}

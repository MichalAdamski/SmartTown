using System;
using UnityEngine;

public class Swiatla : MonoBehaviour {

    public new BoxCollider collider;
    private bool x=false;
    
    void Start()
    {
        collider = GetComponent<BoxCollider>();
        gameObject.GetComponent<Renderer>().material.color = Color.green;
        collider.size.Set(5.514374f, 2.04073f, 3.992094f);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            x=!x;
            

        if (x)
            {
                gameObject.GetComponent<Renderer>().material.color = Color.red;
                gameObject.tag = "Stop";
           
            }
        else
            {
                gameObject.GetComponent<Renderer>().material.color = Color.green;
                gameObject.tag = "lights";
            }
        }
    }
}


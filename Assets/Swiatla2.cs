using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swiatla2 : MonoBehaviour { 

    public new BoxCollider collider;
    private bool y = true;

    void Start()
    {
        collider = GetComponent<BoxCollider>();
        gameObject.GetComponent<Renderer>().material.color = Color.red;
        collider.size.Set(5.514374f, 2.04073f, 3.992094f);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            y = !y;
            if (y)
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

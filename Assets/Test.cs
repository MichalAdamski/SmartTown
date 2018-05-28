using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{

    public GameObject cube;
    public Material red;
    public Material green;
    private Material mat;
    bool canGo;

    public void OnTriggerStay(Collider other)
    {
        if(!canGo)
            cube.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
        else
            cube.GetComponent<Rigidbody>().velocity = new Vector3(-5, 0, 0);
    }
        
    // Use this for initialization
    void Start()
    {
        GetComponent<Renderer>().material = red;
        cube.GetComponent<Rigidbody>().velocity = new Vector3(-5, 0, 0);
        canGo = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            canGo = !canGo;
            if (canGo)
            {
                GetComponent<Renderer>().material = green;
            }
            else
            {
                GetComponent<Renderer>().material = red;
            }
        }
    }
}

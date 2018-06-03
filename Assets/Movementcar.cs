using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movementcar : MonoBehaviour
{
    
    private new Rigidbody rigidbody;
    private new Collider collider;
    public float time = 0.4f;
    bool shouldMove = true;
    int skret;
    bool obracanie = false;
    private int zmienna=0;
    bool czyUderzyl = false;
    string kat = "";
    public float a;
    

    private void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        rigidbody.collisionDetectionMode = CollisionDetectionMode.ContinuousDynamic;
        collider = GetComponent<Collider>();
        skret = Random.Range(0,3);
    }

    private void Update()
    {
        if (shouldMove)
        {
            transform.Translate(Vector3.down * time, Space.Self);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.GetType() == typeof(SphereCollider))
        {
            kat = other.tag;
            a = float.Parse(kat);
            zmienna++;
        }
        if (!czyUderzyl)
        {
            if (other.gameObject.tag == "Stop")
            {
                shouldMove = false;
            }
        }
        else
        {
            shouldMove = true;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "lights")
        {
            shouldMove = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        czyUderzyl = true;
        if (skret == 2 && !obracanie && zmienna == skret)
        {
            transform.Rotate(0.0f, 0.0f, -a);
            obracanie = true;
        }
        else if (skret == 1 && !obracanie && zmienna == skret)
        {
            transform.Rotate(0.0f, 0.0f, a);
            obracanie = true;
        }
    }
}

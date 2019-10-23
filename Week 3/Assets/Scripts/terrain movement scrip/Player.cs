using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    Rigidbody rb;
    public float forceammount;



    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(new Vector3(0f, 0f, 1f) * forceammount);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(new Vector3(0f, 0f, -1f) * forceammount);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(new Vector3(-1f, 0f, 0f) * forceammount);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(new Vector3(1f, 0f, 0f) * forceammount);
        }

    }
}

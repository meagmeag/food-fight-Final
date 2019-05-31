using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    Rigidbody rb;
    public float thrust = 20;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!Input.GetKey(KeyCode.Tab))
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
                    rb.AddForce(Vector3.forward * thrust * 2);
                if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
                    rb.AddForce(Vector3.forward * thrust * -2);
                if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
                    rb.AddForce(Vector3.right * thrust * 2);
                if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
                    rb.AddForce(Vector3.right * thrust * -2);
            }
            else
            {
                if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
                    rb.AddForce(Vector3.forward * thrust);
                if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
                    rb.AddForce(Vector3.forward * thrust * -1);
                if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
                    rb.AddForce(Vector3.right * thrust);
                if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
                    rb.AddForce(Vector3.right * thrust * -1);
            }
        }
        if (Input.GetKey(KeyCode.R))
        {
            rb.rotation = Quaternion.identity;
            rb.position = Vector3.zero;
        }
    }
    //does this work

    }


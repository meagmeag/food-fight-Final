using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{

    Rigidbody rb;
    public float thrust = 10;
    bool grounded;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnCollisionStay(Collision collision)
    {
        grounded = true;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //super jump
            if (Input.GetKey(KeyCode.LeftShift))
            {
                if (grounded)
                    rb.AddForce(Vector3.up * thrust * 2f, ForceMode.Impulse);
                if (!grounded)
                    rb.AddForce(Vector3.up * thrust * 1.25f, ForceMode.Impulse);
            }
            //normal jump
            else
            {
                if (!grounded)
                    rb.AddForce(Vector3.up * thrust * .5f, ForceMode.Impulse);
                else if (grounded)
                    rb.AddForce(Vector3.up * thrust, ForceMode.Impulse);
            }
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        grounded = false;
    }
}

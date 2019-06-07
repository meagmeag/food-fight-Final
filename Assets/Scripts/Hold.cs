using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hold : MonoBehaviour
{

    private bool touching = false;
    List<GameObject> heldObjs;
    GameObject touched;
    Rigidbody rb, rb2;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {

        if (!collision.gameObject.name.Equals("Ground"))
        {
            touching = true;
            touched = collision.gameObject;
            rb2 = touched.GetComponent<Rigidbody>();
        }


    }
    


    // Update is called once per frame
    void Update()
    {
        if (touching)
        {
            if (Input.GetKey(KeyCode.I))
            {
                rb2.isKinematic = true;
                rb2.position = rb.position + transform.lossyScale;
            }

            if (!Input.GetKey(KeyCode.I))
            {
                rb2.isKinematic = false;
                touching = false;
            }
        }
    }

}

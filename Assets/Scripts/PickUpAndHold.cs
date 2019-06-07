using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUpandHold : MonoBehaviour {
    Rigidbody rb, rb2;
    private bool touching;
    GameObject touched;
    public List<GameObject> inventory;
    public Text picked;

	// Use this for initialization
	void Start () {
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

    private void OnCollisionStay(Collision collision)
    {
        if (!collision.gameObject.name.Equals("Ground"))
        {
            touching = true;
            touched = collision.gameObject;
            rb2 = touched.GetComponent<Rigidbody>();
            
        }
    }

    // Update is called once per frame
    void Update () {
		if(Input.GetKey(KeyCode.Q) && touching)
        {
            inventory.Add(touched);
            picked.text = "Picked up" + touched.name;
            Destroy(touched);
        }
	}
}

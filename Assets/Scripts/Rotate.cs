using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{

    Rigidbody rb;
    public float thrust = 5;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.Tab)) {
            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
                rb.transform.Rotate(thrust, 0, 0, Space.World);
            else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
                rb.transform.Rotate(thrust * -1, 0, 0, Space.World);
            else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
                rb.transform.Rotate(0, 0, thrust * -1, Space.World);
            else if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
                rb.transform.Rotate(0, 0, thrust, Space.World);
            //tab + E resets rotation only
            if (Input.GetKey(KeyCode.E))
                rb.rotation = Quaternion.identity;
        }
    }
}

    

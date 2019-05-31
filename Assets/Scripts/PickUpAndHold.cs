using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpAndHold : MonoBehaviour {

    private bool touching;
	// Use this for initialization
	void Start () {
		
	}

    private void OnCollisionStay(Collision collision)
    {
        if()
        touching = true;
    }
    // Update is called once per frame
    void Update () {
		if(touching && Input.GetKey(KeyCode.Q))
        {

        }
	}


}

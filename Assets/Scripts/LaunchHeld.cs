using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LaunchHeld : MonoBehaviour {
    
    GameObject obj;
    Rigidbody rb;
    public Text inventoryTxt;
    public Text launch;


    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.Q))
        {
            if (PickUpandHold.inventory.Count > 0)
            {
                launch.text = "";
                obj = Instantiate(PickUpandHold.inventory[0], transform.position + transform.lossyScale, Quaternion.identity);
                Destroy(PickUpandHold.inventory[0]);
                PickUpandHold.inventory.RemoveAt(0);
                inventoryTxt.text = "# in inventory:" + PickUpandHold.inventory.Count;
                rb = obj.GetComponent<Rigidbody>();
                obj.SetActive(true);
                rb.AddForce(transform.forward * 5);
            }
            else
                launch.text = "Nothing to launch!";
            
        }
		
	}
}

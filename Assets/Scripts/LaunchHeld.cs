using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LaunchHeld : MonoBehaviour {
    
    GameObject obj;
    Rigidbody rb;
    public Text inventoryTxt;
    public Text launch;
    private List<GameObject> launched = new List<GameObject>();


    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKeyDown(KeyCode.Q))
        {
            if (PickUpandHold.inventory.Count > 0)
            {
                obj = Instantiate(PickUpandHold.inventory[0], transform.position + transform.lossyScale, Quaternion.identity);
                Destroy(PickUpandHold.inventory[0]);
                PickUpandHold.inventory.RemoveAt(0);
                inventoryTxt.text = "Objects in inventory: " + PickUpandHold.inventory.Count;
                rb = obj.GetComponent<Rigidbody>();
                obj.SetActive(true);
                rb.AddForce(transform.forward * 1000);
                launched.Add(obj);
            }
            else
                launch.text = "Nothing to launch!";
            
        }

        if (Input.GetKeyDown(KeyCode.X))
            for (int i = 0; i < launched.Count; i++)
                Destroy(launched[i]);


    }
}

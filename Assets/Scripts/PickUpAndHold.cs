using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUpandHold : MonoBehaviour
{
    Rigidbody rb, rb2;
    private bool touching;
    GameObject touched;
    public static List<GameObject> inventory = new List<GameObject>();
    public Text inventoryTxt, launchTxt;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.gameObject.name.Equals("Ground") && !collision.gameObject.name.Contains("bump"))
        {
            touching = true;
            touched = collision.gameObject;
            rb2 = touched.GetComponent<Rigidbody>();
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if (!collision.gameObject.name.Equals("Ground") && !collision.gameObject.name.Contains("bump"))
        {
            touching = true;
            touched = collision.gameObject;
            rb2 = touched.GetComponent<Rigidbody>();

        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Q) && touching && !Input.GetKey(KeyCode.LeftShift))
        {
            launchTxt.text = "";
            touched.SetActive(false);
            inventory.Add(touched);
            inventoryTxt.text = "Objects in inventory: " + inventory.Count;
            touching = false;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        touching = false;
    }
}

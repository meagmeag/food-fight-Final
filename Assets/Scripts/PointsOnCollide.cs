using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PointsOnCollide : MonoBehaviour
{
    Rigidbody rb;
    private static int points = 0;
    public Text pointsTxt;
    public int pointVal;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.gameObject.name.Equals("Ground") && !collision.gameObject.name.Equals("Character"))
        {
            points += pointVal;
            pointsTxt.text = "Points: " + points;
        }
    }
}

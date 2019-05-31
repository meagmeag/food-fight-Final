using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseRandomObject : MonoBehaviour {

    //add shapes to shapes in inspector
    public List<GameObject> shapes = new List<GameObject>();
    public List<GameObject> spawnedShapes = new List<GameObject>();
    GameObject obj;
    Rigidbody rb;

	// Use this for initialization
	void Start () {
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.F))
        {
            int ran = Random.Range(0, shapes.Count);
            obj = Instantiate(shapes[ran], transform.position, Quaternion.identity);
            rb = obj.AddComponent<Rigidbody>();
            spawnedShapes.Add(obj);

            //spawn and launch in random direction
            if (Input.GetKey(KeyCode.LeftShift))
            {
                int ranX = Random.Range(-360,360);
                int ranY = Random.Range(-360, 360);
                Vector3 force = new Vector3(ranX, 0, ranY);
                rb.AddForce(force * 5);
            }
        }
        
        //deletes all spawned objects
        if (Input.GetKeyDown(KeyCode.X))
            for (int i = 0; i < spawnedShapes.Count; i++)
                Destroy(spawnedShapes[i]);

    }
}

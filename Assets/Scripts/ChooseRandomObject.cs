using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseRandomObject : MonoBehaviour {

    //add shapes to shapes in inspector
    public List<GameObject> shapes = new List<GameObject>();
    public List<GameObject> spawnedShapes = new List<GameObject>();

	// Use this for initialization
	void Start () {
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.F))
        {
            int ran = Random.Range(0, shapes.Count);
            GameObject obj = Instantiate(shapes[ran], transform.position, Quaternion.identity);
            spawnedShapes.Add(obj);
        }
        if (Input.GetKeyDown(KeyCode.X))
            for (int i = 0; i < spawnedShapes.Count; i++)
                Destroy(spawnedShapes[i]);

    }
}

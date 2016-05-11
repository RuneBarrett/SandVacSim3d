using UnityEngine;
using System.Collections;

public class createBody : MonoBehaviour {

    Rigidbody rb;
    RaycastHit hit;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        if (rb == null) {
            if (Physics.Raycast(transform.position, Vector3.down, out hit)){
                print("Found an object - distance: " + hit.distance + " " + hit.transform);
                gameObject.AddComponent<Rigidbody>();
                rb = GetComponent<Rigidbody>();
                rb.drag = 0.2f;
                
            }

        }
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class прыжок : MonoBehaviour {
	RaycastHit hit;
	LayerMask mask;
	Rigidbody rd;
	// Use this for initialization
	void Start () 
	{
		mask = LayerMask.GetMask ("Default");
		rd = GetComponent<Rigidbody> ();
		Debug.Log (rd);
	}
	
	// Update is called once per frame
	void Update ()
	{
	if (Input.GetKeyDown("space") && Input.GetKey("z"))  
		{
			if (Physics.Raycast (transform.position, transform.TransformDirection (Vector3.down), out hit, 2, mask))
			{
			rd.AddForce(Vector3.up * 1300);
			}
				
		}

		 if (Input.GetKeyDown ("space"))  
		{
			if (Physics.Raycast (transform.position, transform.TransformDirection (Vector3.down), out hit, 2, mask))
			{
				rd.AddForce(Vector3.up * 4300);
			}
	}
}
}
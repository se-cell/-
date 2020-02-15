using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class житель : MonoBehaviour {

	float l = 0f ;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKey ("g")) {
		
			l = l - 90;
		}
		transform.rotation = Quaternion.Euler (0, 0, l);	
//
//		
//		
	}
}


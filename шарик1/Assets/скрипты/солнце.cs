using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class солнце : MonoBehaviour {
	float g = 0f ;
	float h = 0.002f ;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		this.transform.rotation = Quaternion.Euler (g, 0, 0);	
	
		g = g + h;

		if (Input.GetKey ("r")) {
			g = g + 1;
		}
	}
}

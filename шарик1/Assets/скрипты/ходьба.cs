using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ходьба : MonoBehaviour {

	public float speed = 5f;
	 float speed3 = 10f;
	 float speed2 = 5f;
	float v = 1.5f;

	void Update () 
	{
		if (Input.GetKey ("x"))  
		{
			speed = speed3;
		}

		if (Input.GetKeyUp ("x"))  
		{
			speed = speed2;
		}

		if (Input.GetKey ("w"))  
		{
			this.transform.position += transform.forward *(Time.deltaTime * speed) ;
		}

		if (Input.GetKey ("s"))  
		{
			this.transform.position += transform.forward *(Time.deltaTime * -speed / v ) ;
		}
			

		if (Input.GetKey ("d"))  
		{
			this.transform.position += transform.right *(Time.deltaTime * speed2 / 2) ;
		}

		if (Input.GetKey ("a"))  
		{
			this.transform.position += transform.right *(-Time.deltaTime * speed2 / 2) ;
		}




	
	}
}

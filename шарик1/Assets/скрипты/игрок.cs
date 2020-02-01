using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class игрок : MonoBehaviour {
		
	public float speed = 5f ;
	 float g = 0f ;
	 float k = 0f ;

	
	void Update () 
	{

		this.transform.rotation = Quaternion.Euler (0, g, 0);	

		if (Input.GetKey ("w"))  
		{
			this.transform.position += transform.forward *(Time.deltaTime * speed) ;
		}

		if (Input.GetKey ("s"))  
		{
			this.transform.position += transform.forward *(Time.deltaTime * -speed) ;
		}

		if (Input.GetKey ("a"))  
		{	
			g = g - 1 ;
		}

		if (Input.GetKey ("d")) {
			g = g + 1;
		}


	}
}

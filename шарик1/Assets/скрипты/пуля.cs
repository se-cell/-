using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class пуля : MonoBehaviour {

	Rigidbody rd;
	public Transform v;
	private Quaternion Q;

	// Use this for initialization
	void Start () 
	{  
		rd = GetComponent<Rigidbody> ();
//		Debug.Log (rd);	
		rd.AddForce (Vector3.forward * 4000);
		//Q = v.transform.Rotation;
	}
	
	// Update is called once per frame
	void Update ()
	{
		//transform.localRotation = Q * Q *  Q;
	}
}

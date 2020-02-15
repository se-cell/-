using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class пушка3 : MonoBehaviour {

	public GameObject yu;
	public GameObject yu2;
	private GameObject t2;
	private GameObject t3;
	public Transform v;
	public Transform v2;
	public float n = 1f;

	void Update () 
	{
		if (Input.GetButtonDown("Fire2"))
		{
			spop ();
		}


	}
	void spop () 
	{
		t2 = Instantiate(yu, v.position, v.rotation);
		t3 = Instantiate(yu2, v2.position, v2.rotation);
		t2.GetComponent<Rigidbody>().AddForce (t2.transform.forward * n, ForceMode.Impulse);
		Destroy (t2, 3f);
		Destroy (t3, 4f);
	}
}

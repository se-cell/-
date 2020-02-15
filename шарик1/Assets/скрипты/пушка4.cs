using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class пушка4 : MonoBehaviour {

	public GameObject yu;
	public GameObject yu2;
	private GameObject t2;
	private GameObject t3;
	private GameObject t4;
	private GameObject t5;
	private GameObject t6;
	private GameObject t7;
	public Transform v;
	public Transform tv;
	public Transform v3;
	public Transform v4;
	public Transform v5;
	public Transform v6;
	public float n = 1f;

	void Update () 
	{
		if (Input.GetButtonDown("Fire3"))
		{
			spop ();
		}


	}
	void spop () 
	{
		t2 = Instantiate(yu, v.position, v.rotation);
		t4 = Instantiate(yu, v3.position, v3.rotation);
		t5 = Instantiate(yu, v4.position, v4.rotation);
		t6 = Instantiate(yu, v5.position, v5.rotation);
		t7 = Instantiate(yu, v6.position, v6.rotation);
		t3 = Instantiate(yu2, tv.position, tv.rotation);
		t2.GetComponent<Rigidbody>().AddForce (t2.transform.forward * n, ForceMode.Impulse);
		t4.GetComponent<Rigidbody>().AddForce (t4.transform.forward * n, ForceMode.Impulse);
		t5.GetComponent<Rigidbody>().AddForce (t5.transform.forward * n, ForceMode.Impulse);
		t6.GetComponent<Rigidbody>().AddForce (t6.transform.forward * n, ForceMode.Impulse);
		t7.GetComponent<Rigidbody>().AddForce (t7.transform.forward * n, ForceMode.Impulse);
		Destroy (t2, 2f);
		Destroy (t4, 2f);
		Destroy (t5, 2f);
		Destroy (t6, 2f);
		Destroy (t7, 2f);
		Destroy (t3, 4f);
	}
}

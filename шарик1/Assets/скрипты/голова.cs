using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class голова : MonoBehaviour {
	public float x = 0;
	public float y = 0;
	public float w = 90;
	public float s = -90;
	public float a = 60;
	public float d = -60;
	float n = 0;
	private Quaternion Q;
	private Quaternion M;
	private float x1 = 0;
	private float y1 = 0;
	void Start () 
	{
		Rigidbody u = GetComponent<Rigidbody> ();
		if (u) 
		{
			u.freezeRotation = true;

		}
		Q = transform.localRotation;
		M = transform.localRotation ;
	}
	void Update ()

	{
		if (Input.GetKey ("f"))		{
			x1 += Input.GetAxis ("Mouse X");
			y1 += Input.GetAxis ("Mouse Y");

			x1 = x1 % 360;
			y1 = y1 % 360;

			x1 = Mathf.Clamp (x1, s, w);
			y1 = Mathf.Clamp (y1, d, a);

			Quaternion Q3 = Quaternion.AngleAxis (x1, Vector3.up);
			Quaternion Q2 = Quaternion.AngleAxis (y1, Vector3.left);
			//
			transform.localRotation = Q2 * Q3 * Q;
		}
		if (Input.GetKeyUp ("f")) {
			this.transform.localRotation = M * Q * M;
		}

	}
}

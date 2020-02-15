using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class пушка : MonoBehaviour
{

    public GameObject yu;
    public GameObject yu2;
    private GameObject t2;
    private GameObject t3;
    public Transform v;
    public Transform v2;
    public float n = 1f;
    public float T = 72f;
    private float T2 = 9f;
    public float timer = 0.1f;
    public float timer2 = 4f;


    void Start()
    {
        T2 = T;
    }


    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            timer = timer2;
        }



        if (timer <= timer2 && Input.GetButton("Fire1"))
        {
            timer += Time.deltaTime;


            if (Input.GetButton("Fire1") && T > 0 && timer > timer2)
            {
                spop();
                T = T - 1;
            }

        }
        else timer = 0;

        if (Input.GetKeyDown("r"))
        {
            T = T2;
        }
    }






    void spop()
    {
        t2 = Instantiate(yu, v.position, v.rotation);
        t3 = Instantiate(yu2, v2.position, v2.rotation);
        t2.GetComponent<Rigidbody>().AddForce(t2.transform.forward * n, ForceMode.Impulse);
        Destroy(t2, 3f);
        Destroy(t3, 4f);
    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class кубик : MonoBehaviour
{
    public GameObject yu;
    private GameObject t2;
    public Transform v;
  
   

    void Start()
    {
      
    }


    void Update()
    {     
                spop();
    }


    void spop()
    {
        t2 = Instantiate(yu, v.position, v.rotation);
        Destroy(t2, 1f);
    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class монетка : MonoBehaviour
{
    public bool pro;
    static public float money;
    public Text TextMon;
    public int Cena;


    void OnTriggerEnter(Collider col)
    { if (col.gameObject.CompareTag("pickup") && pro == true)
        {
            money = money + Cena;
            Destroy(col.gameObject);
            TextMon.text = money.ToString();
            pro = false;
        }
        else pro = true;
    }
}
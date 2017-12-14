using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Light : MonoBehaviour {
    public GameObject Pointlight;
    public GameObject ki;

    // Use this for initialization
    void Start () {
        Pointlight = GameObject.Find("Sutanndo").gameObject.transform.Find("Point light").gameObject;
        Pointlight.SetActive(false);
        ki = GameObject.Find("ki").gameObject;
        ki.SetActive(false);
	}
	
	 
	void Update () {
       //int battery = ItemGet.battery;
        if (Input.GetKeyDown(KeyCode.H) )
        {
            Pointlight.SetActive(true);
            ki.SetActive(true);
        }

    }
}

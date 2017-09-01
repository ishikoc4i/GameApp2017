using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Light : MonoBehaviour {
    public GameObject Pointlight;

    // Use this for initialization
    void Start () {
        Pointlight.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
        if (ItemGet.puragu == true && ItemGet.dennkyuu == true && ItemGet.Key == true && ItemGet.kouguBako == true)
        {
            Pointlight.SetActive(true);
        }

    }
}

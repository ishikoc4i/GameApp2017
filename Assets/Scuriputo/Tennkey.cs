using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tennkey : MonoBehaviour {


    public GameObject Pannel;
    public GameObject screen1;
    





    // Use this for initialization
    void Start () {
        Pannel = GameObject.Find("Canvas").gameObject.transform.Find("Tennkey").gameObject;
        Pannel.SetActive(false);

    }

    

    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Pannel.SetActive(!Pannel.activeSelf);
            Pannel.SetActive(true);


        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Light_kirikae : MonoBehaviour
{

    //Menu ptrMenu;
    // Use this for initialization

    public GameObject LightImage;
    public int battery;
    public GameObject Pointlight;
    public GameObject ki;

    void Start()
    {
        Pointlight = GameObject.Find("Sutanndo").gameObject.transform.Find("Point light").gameObject;
        Pointlight.SetActive(false);
        ki = GameObject.Find("ki").gameObject;
        ki.SetActive(false);

    }

    void OnTriggerStay(Collider other)
    {
        battery = ItemGet.battery;

        if (other.gameObject.CompareTag("Player"))
        {

            LightImage = GameObject.Find("Canvas").gameObject.transform.Find("LightImage").gameObject;
            LightImage.SetActive(true);

            if (Input.GetKeyDown(KeyCode.H))
            {
                if(battery == 1)
                {
                    Pointlight.SetActive(true);
                    ki.SetActive(true);
                }
                
            }

        }

    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            LightImage = GameObject.Find("Canvas").gameObject.transform.Find("LightImage").gameObject;
            LightImage.SetActive(false);
        }
    }



    // Update is called once per frame
    void Update()
    {

    }
}

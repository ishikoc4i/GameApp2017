using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class GetKyeHyouzi : MonoBehaviour
{

    //Menu ptrMenu;
    // Use this for initialization

    public GameObject Image;


    void Start()
    {


    }

    void OnTriggerStay(Collider other)
    {

        if (other.gameObject.CompareTag("Player"))
        {

            Image = GameObject.Find("Canvas").gameObject.transform.Find("Image").gameObject;
            Image.SetActive(true);

        }

    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Image = GameObject.Find("Canvas").gameObject.transform.Find("Image").gameObject;
            Image.SetActive(false);
        }
    }

    

    // Update is called once per frame
    void Update()
    {

    }
}

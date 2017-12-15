using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TennkyHyouzi : MonoBehaviour {


    public GameObject Image;
    public GameObject Tennkey;
    // Use this for initialization
    void Start () {
		
	}



    void OnTriggerStay(Collider other)
    {
        int j = Button.j;

        if (other.gameObject.CompareTag("Player"))
        {
            if(j == 0){

                Tennkey = GameObject.Find("Canvas").gameObject.transform.Find("Tennkey").gameObject;
                Tennkey.SetActive(true);

            }

        }

    }




    void OnTriggerExit(Collider other)
    {

        

        if (other.gameObject.CompareTag("Player"))
        {
            
            Tennkey = GameObject.Find("Canvas").gameObject.transform.Find("Tennkey").gameObject;
            Tennkey.SetActive(false);

        }
    }




    // Update is called once per frame
    void Update () {
		
	}
}

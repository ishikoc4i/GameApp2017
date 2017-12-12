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

        if (other.gameObject.CompareTag("Player"))
        {

            //Image = GameObject.Find("Canvas").gameObject.transform.Find("Image").gameObject;
            //Image.AddComponent<Image>().sprite = Resources.Load<Sprite>("素材１２");

            Tennkey = GameObject.Find("Canvas").gameObject.transform.Find("Tennkey").gameObject;
            Tennkey.SetActive(true);

        }

    }




    void OnTriggerExit(Collider other)
    {

        

        if (other.gameObject.CompareTag("Player"))
        {
            //Image = GameObject.Find("Canvas").gameObject.transform.Find("Image").gameObject;
            //Image.SetActive(false);
            Tennkey = GameObject.Find("Canvas").gameObject.transform.Find("Tennkey").gameObject;
            Tennkey.SetActive(false);

        }
    }




    // Update is called once per frame
    void Update () {
		
	}
}

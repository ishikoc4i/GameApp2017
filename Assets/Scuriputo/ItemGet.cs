﻿using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;
using System.Collections;



public class ItemGet : MonoBehaviour
{

    public Ray ray;
    public Ray rayItem;
    public RaycastHit hit;


    public GameObject Image;
    public GameObject ReadImage;
    public GameObject ReadImage1;
    public GameObject ReadImage2;
    public GameObject ReadImage3;
    public GameObject ReadImage4;


    public static int Chemicalsbottle = 0;
    public static int battery = 0;
    public static int Rustedkey = 0;
    public static int Hoistwaykey = 0;
    public static int shelfkey = 0;

    


    // Use this for initialization
    void Start()
    {


        GameObject Readimage1 = new GameObject("ReadImage1");
        Readimage1.transform.parent = GameObject.Find("Canvas").transform;
        Readimage1.AddComponent<RectTransform>().anchoredPosition = new Vector3(0, 0, 0);
        Readimage1.GetComponent<RectTransform>().localScale = new Vector3(1, 1, 1);
        Readimage1.AddComponent<Image>().sprite = Resources.Load<Sprite>("素材７");
        Readimage1.GetComponent<Image>().preserveAspect = true;
        Readimage1.GetComponent<Image>().SetNativeSize();
        ReadImage1 = GameObject.Find("Canvas").gameObject.transform.Find("ReadImage1").gameObject;
        ReadImage1.SetActive(false);


        GameObject Readimage2 = new GameObject("ReadImage2");
        Readimage2.transform.parent = GameObject.Find("Canvas").transform;
        Readimage2.AddComponent<RectTransform>().anchoredPosition = new Vector3(0, 0, 0);
        Readimage2.GetComponent<RectTransform>().localScale = new Vector3(1, 1, 1);
        Readimage2.AddComponent<Image>().sprite = Resources.Load<Sprite>("素材８");
        Readimage2.GetComponent<Image>().preserveAspect = true;
        Readimage2.GetComponent<Image>().SetNativeSize();
        ReadImage2 = GameObject.Find("Canvas").gameObject.transform.Find("ReadImage2").gameObject;
        ReadImage2.SetActive(false);


        GameObject Readimage3 = new GameObject("ReadImage3");
        Readimage3.transform.parent = GameObject.Find("Canvas").transform;
        Readimage3.AddComponent<RectTransform>().anchoredPosition = new Vector3(0, 0, 0);
        Readimage3.GetComponent<RectTransform>().localScale = new Vector3(1, 1, 1);
        Readimage3.AddComponent<Image>().sprite = Resources.Load<Sprite>("素材９");
        Readimage3.GetComponent<Image>().preserveAspect = true;
        Readimage3.GetComponent<Image>().SetNativeSize();
        ReadImage3 = GameObject.Find("Canvas").gameObject.transform.Find("ReadImage3").gameObject;
        ReadImage3.SetActive(false);


        GameObject Readimage4 = new GameObject("ReadImage4");
        Readimage4.transform.parent = GameObject.Find("Canvas").transform;
        Readimage4.AddComponent<RectTransform>().anchoredPosition = new Vector3(0, 0, 0);
        Readimage4.GetComponent<RectTransform>().localScale = new Vector3(1, 1, 1);
        Readimage4.AddComponent<Image>().sprite = Resources.Load<Sprite>("素材１０");
        Readimage4.GetComponent<Image>().preserveAspect = true;
        Readimage4.GetComponent<Image>().SetNativeSize();
        ReadImage4 = GameObject.Find("Canvas").gameObject.transform.Find("ReadImage4").gameObject;
        ReadImage4.SetActive(false);


    }




    // Update is called once per frame
    public void Update()
    {


        if (Input.GetKeyDown(KeyCode.H))
        {
            //Ray ray = new Ray(transform.position, transform.forward);
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit hit;

            int distance = 40;

            Debug.DrawLine(ray.origin, ray.direction * distance, Color.red);



            if (Physics.SphereCast(ray, 0.1f, out hit, 50.0f))
            //if (Physics.Raycast(ray, out hit, distance))
            {
                if (hit.collider.name == "Chemicalsbottle")
                {
                    Destroy(hit.collider.gameObject);
                    Image = GameObject.Find("Canvas").gameObject.transform.Find("Image").gameObject;
                    Image.SetActive(false);
                    Chemicalsbottle = 1;
                }

                if (hit.collider.name == "battery")
                {
                    Destroy(hit.collider.gameObject);
                    Image = GameObject.Find("Canvas").gameObject.transform.Find("Image").gameObject;
                    Image.SetActive(false);
                    battery = 1;
                }
                if (hit.collider.name == "Rustedkey")
                {
                    Destroy(hit.collider.gameObject);
                    Image = GameObject.Find("Canvas").gameObject.transform.Find("Image").gameObject;
                    Image.SetActive(false);
                    Rustedkey = 1;
                }
                if (hit.collider.name == " Hoistwaykey")
                {
                    Destroy(hit.collider.gameObject);
                    Image = GameObject.Find("Canvas").gameObject.transform.Find("Image").gameObject;
                    Image.SetActive(false);
                    Hoistwaykey = 1;
                }

                if (Chemicalsbottle == 1 && Rustedkey == 1)
                {
                    shelfkey = 1;
                }








                if (hit.collider.name == "ChemicalBook")
                {
                    ReadImage = GameObject.Find("Canvas").gameObject.transform.Find("ReadImage").gameObject;
                    ReadImage.SetActive(false);
                    ReadImage1.SetActive(!ReadImage1.activeSelf);

                }
                

                if (hit.collider.name == "ElectricalBook1")
                {
                    ReadImage = GameObject.Find("Canvas").gameObject.transform.Find("ReadImage").gameObject;
                    ReadImage.SetActive(false);
                    ReadImage2.SetActive(!ReadImage2.activeSelf);

                }

                if (hit.collider.name == "ElectricalBook2")
                {
                    ReadImage = GameObject.Find("Canvas").gameObject.transform.Find("ReadImage").gameObject;
                    ReadImage.SetActive(false);
                    ReadImage3.SetActive(!ReadImage3.activeSelf);

                }

                if (hit.collider.name == "ElectricalBook2")
                {
                    ReadImage = GameObject.Find("Canvas").gameObject.transform.Find("ReadImage").gameObject;
                    ReadImage.SetActive(false);
                    ReadImage4.SetActive(!ReadImage4.activeSelf);

                }



            }
        }
    }
}


   
using UnityEngine;
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
    public static bool puragu = false;
    public static bool dennkyuu = false;
    public static bool Key = false;
    public static bool kouguBako = false;

    // Use this for initialization
    void Start()
    {



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
                if (hit.collider.name == "puragu")
                {
                    Destroy(hit.collider.gameObject);
                    Image = GameObject.Find("Canvas").gameObject.transform.Find("Image").gameObject;
                    Image.SetActive(false);
                    puragu = true;
                    Debug.Log(puragu);



                }
                if (hit.collider.name == "dennkyuu")
                {
                    Destroy(hit.collider.gameObject);
                    Image = GameObject.Find("Canvas").gameObject.transform.Find("Image").gameObject;
                    Image.SetActive(false);
                    dennkyuu = true;
                    Debug.Log(dennkyuu);
                }
                if (hit.collider.name == "Key")
                {
                    Destroy(hit.collider.gameObject);
                    Image = GameObject.Find("Canvas").gameObject.transform.Find("Image").gameObject;
                    Image.SetActive(false);
                    Key = true;
                    Debug.Log(Key);
                }
                if (hit.collider.name == "kouguBako")
                {
                    Destroy(hit.collider.gameObject);
                    Image = GameObject.Find("Canvas").gameObject.transform.Find("Image").gameObject;
                    Image.SetActive(false);
                    kouguBako = true;
                    Debug.Log(kouguBako);
                }

            }
        }
    }
}


   
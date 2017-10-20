using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class ReadKey : MonoBehaviour
{

    //Menu ptrMenu;
    // Use this for initialization

    public GameObject Image;
    public bool k = true;
    public GameObject Readimage;


    void Start()
    {
        GameObject Readimage = new GameObject("ReadImage");
        Readimage.transform.parent = GameObject.Find("Canvas").transform;
        Readimage.AddComponent<RectTransform>().anchoredPosition = new Vector3(0, 0, 0);
        Readimage.GetComponent<RectTransform>().localScale = new Vector3(1, 1, 1);
        Readimage.AddComponent<Image>().sprite = Resources.Load<Sprite>("素材４");
        Readimage.GetComponent<Image>().preserveAspect = true;
        Readimage.GetComponent<Image>().SetNativeSize();
        Readimage.SetActive(false);

    }

    void OnTriggerStay(Collider other)
    {

        if (other.gameObject.CompareTag("Player"))
        {
            Readimage = GameObject.Find("Canvas").gameObject.transform.Find("ReadImage").gameObject;
            Readimage.SetActive(true);
            
        }

    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Readimage = GameObject.Find("Canvas").gameObject.transform.Find("ReadImage").gameObject;
            
            Readimage.SetActive(false);

        }
    }



    // Update is called once per frame
    void Update()
    {

    }
}

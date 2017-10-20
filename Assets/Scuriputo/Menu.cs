using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{

    private GameObject scrollRect;
    public GameObject Image;
    public GameObject ContlloleImage;
    public GameObject canvasObject;

    // Use this for initialization
    void Start()
    {
        scrollRect = this.gameObject.transform.Find("ItemRisuto").gameObject;
        scrollRect.SetActive(false);


        Image = this.gameObject.transform.Find("Image").gameObject;
        Image.SetActive(false);

        ContlloleImage = this.gameObject.transform.Find("ContlloleImage").gameObject;
        ContlloleImage.SetActive(true);
        

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.anyKeyDown)
        {
            ContlloleImage.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.G))
        {
            scrollRect.SetActive(!scrollRect.activeSelf);

        }
    }



    /*public void Hyouzi()
    {
        Image = GameObject.Find("Canvas").gameObject.transform.Find("Image").gameObject;
        Image.SetActive(true);

    }*/
}

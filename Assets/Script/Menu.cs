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
    public GameObject Pannel;
    public GameObject SenntakuPaneru;
    public int Chemicalsbottle;
    public int Rustedkey;
    public int ChemicalBook;
    

    // Use this for initialization
    void Start()
    {
        scrollRect = this.gameObject.transform.Find("ItemRisuto").gameObject;
        scrollRect.SetActive(false);


        Image = this.gameObject.transform.Find("Image").gameObject;
        Image.SetActive(false);

        ContlloleImage = this.gameObject.transform.Find("ContlloleImage").gameObject;
        ContlloleImage.SetActive(true);

        Pannel = GameObject.Find("Canvas").gameObject.transform.Find("Tennkey").gameObject;
        Pannel.SetActive(false);

        SenntakuPaneru = GameObject.Find("Canvas").gameObject.transform.Find("SenntakuPaneru").gameObject;
        SenntakuPaneru.SetActive(false);

        
    }

    // Update is called once per frame
    void Update()
    {
        
        Chemicalsbottle = ItemGet.Chemicalsbottle;
        Rustedkey = ItemGet.Rustedkey;
        ChemicalBook = ItemGet.ChemicalBook;


        if (Input.anyKeyDown)
        {
            ContlloleImage.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            ContlloleImage.SetActive(!ContlloleImage.activeSelf);
        }

        if (Input.GetKeyDown(KeyCode.G))
        {
           
            scrollRect.SetActive(!scrollRect.activeSelf);

            if (Chemicalsbottle == 1 && Rustedkey == 1 &&ChemicalBook == 1 )
            {
                SenntakuPaneru.SetActive(!SenntakuPaneru.activeSelf);
                
            }

        }

     
    }



    /*public void Hyouzi()
    {
        Image = GameObject.Find("Canvas").gameObject.transform.Find("Image").gameObject;
        Image.SetActive(true);

    }*/
}

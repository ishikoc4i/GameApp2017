using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Kaihei : MonoBehaviour {

    public GameObject KaiheiImage;
    public GameObject KaiheiImage2;
    public int shelfkey;
    public int o = 0;
    public int X;
    public GameObject nannkinn;
    public GameObject tana_hanntei;
    public GameObject GetImage;
    // Use this for initialization
    void Start () {
		
	}

    void OnTriggerStay(Collider other)
    {

        if (other.gameObject.CompareTag("Player"))
        {

            KaiheiImage = GameObject.Find("Canvas").gameObject.transform.Find("KaiheiImage").gameObject;
            KaiheiImage.SetActive(true);

            if (Input.GetKeyDown(KeyCode.H))
            {

                if (shelfkey == 1 && o == 0)
                {

                    Destroy(nannkinn);
                    GameObject Door = GameObject.Find("tana").gameObject.transform.Find("tanadoor").gameObject;
                    Vector3 v = Door.transform.localPosition;
                    v.z += 5;
                    Door.transform.localPosition = v;
                    o = 1;
                    tana_hanntei = GameObject.Find("tana").gameObject.transform.Find("tana_hanntei").gameObject;
                    tana_hanntei.SetActive(false);
                    KaiheiImage = GameObject.Find("Canvas").gameObject.transform.Find("KaiheiImage").gameObject;
                    KaiheiImage.SetActive(false);

                }

               
            }

        }

    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            KaiheiImage = GameObject.Find("Canvas").gameObject.transform.Find("KaiheiImage").gameObject;
            KaiheiImage.SetActive(false);
        }
    }


    // Update is called once per frame
    void Update() {
        shelfkey = Button.shelfkey;
        //nannkinn = GameObject.Find("GameItem").gameObject.transform.Find("Nannkinnjou").gameObject;
        nannkinn = GameObject.Find("Nannkinnjou");

        X = Button.X;

        if (Input.GetKeyDown(KeyCode.H))
        {

            if (X == 1)
            {
                GetImage = GameObject.Find("Canvas").gameObject.transform.Find("GetImage").gameObject;
                GetImage.SetActive(false);


            }
        }


    }
}

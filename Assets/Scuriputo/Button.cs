using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button : MonoBehaviour {


    public GameObject screen1;
    int ClickCaunt = 0;

	// Use this for initialization
	void Start () {
		
	}


    public void OnButtonClick()
    {
        Debug.Log("Click");

        if (ClickCaunt == 0)
        {
            screen1 = GameObject.Find("Canvas").gameObject.transform.Find("Tennkey").gameObject.transform.Find("screen").gameObject.transform.Find("screen1").gameObject;
            screen1.GetComponent<RectTransform>().localScale = new Vector3(1.5f, 0.7f, 1);
            screen1.GetComponent<Image>().sprite = Resources.Load<Sprite>("数字１");
            screen1.GetComponent<Image>().SetNativeSize();
        }
        
        if (ClickCaunt == 1)
        {
            screen1 = GameObject.Find("Canvas").gameObject.transform.Find("Tennkey").gameObject.transform.Find("screen").gameObject.transform.Find("screen2").gameObject;
            screen1.GetComponent<RectTransform>().localScale = new Vector3(1.5f, 0.7f, 1);
            screen1.GetComponent<Image>().sprite = Resources.Load<Sprite>("数字１");
            screen1.GetComponent<Image>().SetNativeSize();
        }

        if (ClickCaunt == 2)
        {
            screen1 = GameObject.Find("Canvas").gameObject.transform.Find("Tennkey").gameObject.transform.Find("screen").gameObject.transform.Find("screen3").gameObject;
            screen1.GetComponent<RectTransform>().localScale = new Vector3(1.5f, 0.7f, 1);
            screen1.GetComponent<Image>().sprite = Resources.Load<Sprite>("数字１");
            screen1.GetComponent<Image>().SetNativeSize();
        }

        if (ClickCaunt == 3)
        {
            screen1 = GameObject.Find("Canvas").gameObject.transform.Find("Tennkey").gameObject.transform.Find("screen").gameObject.transform.Find("screen4").gameObject;
            screen1.GetComponent<RectTransform>().localScale = new Vector3(1.5f, 0.7f, 1);
            screen1.GetComponent<Image>().sprite = Resources.Load<Sprite>("数字１");
            screen1.GetComponent<Image>().SetNativeSize();
        }
    }

  


    // Update is called once per frame
    void Update () {

       
	}
}

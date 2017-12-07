using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button : MonoBehaviour {


    public GameObject screen1;
    static int ClickCaunt1 = 0;
    static int ClickCaunt2 = 0;
    static int ClickCaunt3 = 0;
    static int ClickCaunt4 = 0;
    static int ClickCaunt5 = 0;
    static int ClickCaunt6 = 0;
    static int ClickCaunt7 = 0;
    static int ClickCaunt8 = 0;
    static int ClickCaunt9 = 0;
    static int ClickCaunt0 = 0;
    static int ClickCaunt_ok = 0;
    static int ClickCaunt_cancel = 0;

    // Use this for initialization
    void Start () {
		
	}


    public void OnButtonClick1()
    {
       

        if (ClickCaunt1 == 0)
        {
            screen1 = GameObject.Find("Canvas").gameObject.transform.Find("Tennkey").gameObject.transform.Find("screen").gameObject.transform.Find("screen1").gameObject;
            screen1.GetComponent<RectTransform>().localScale = new Vector3(1.5f, 0.7f, 1);
            screen1.GetComponent<Image>().sprite = Resources.Load<Sprite>("数字1");
            screen1.GetComponent<Image>().SetNativeSize();
            ClickCaunt1++;
        }
        
        else if (ClickCaunt1 == 1)
        {
            screen1 = GameObject.Find("Canvas").gameObject.transform.Find("Tennkey").gameObject.transform.Find("screen").gameObject.transform.Find("screen2").gameObject;
            screen1.GetComponent<RectTransform>().localScale = new Vector3(1.5f, 0.7f, 1);
            screen1.GetComponent<Image>().sprite = Resources.Load<Sprite>("数字1");
            screen1.GetComponent<Image>().SetNativeSize();
            ClickCaunt1++;
        }

        else if (ClickCaunt1 == 2)
        {
            screen1 = GameObject.Find("Canvas").gameObject.transform.Find("Tennkey").gameObject.transform.Find("screen").gameObject.transform.Find("screen3").gameObject;
            screen1.GetComponent<RectTransform>().localScale = new Vector3(1.5f, 0.7f, 1);
            screen1.GetComponent<Image>().sprite = Resources.Load<Sprite>("数字1");
            screen1.GetComponent<Image>().SetNativeSize();
            ClickCaunt1++;
        }

        else if (ClickCaunt1 == 3)
        {
            screen1 = GameObject.Find("Canvas").gameObject.transform.Find("Tennkey").gameObject.transform.Find("screen").gameObject.transform.Find("screen4").gameObject;
            screen1.GetComponent<RectTransform>().localScale = new Vector3(1.5f, 0.7f, 1);
            screen1.GetComponent<Image>().sprite = Resources.Load<Sprite>("数字1");
            screen1.GetComponent<Image>().SetNativeSize();
            ClickCaunt1++;
        }
    }

    public void OnButtonClick2()
    {
       
        if (ClickCaunt2 == 0)
        {
            screen1 = GameObject.Find("Canvas").gameObject.transform.Find("Tennkey").gameObject.transform.Find("screen").gameObject.transform.Find("screen1").gameObject;
            screen1.GetComponent<RectTransform>().localScale = new Vector3(1.5f, 0.7f, 1);
            screen1.GetComponent<Image>().sprite = Resources.Load<Sprite>("数字2");
            screen1.GetComponent<Image>().SetNativeSize();
            ClickCaunt2++;
        }

        else if (ClickCaunt2 == 1)
        {
            screen1 = GameObject.Find("Canvas").gameObject.transform.Find("Tennkey").gameObject.transform.Find("screen").gameObject.transform.Find("screen2").gameObject;
            screen1.GetComponent<RectTransform>().localScale = new Vector3(1.5f, 0.7f, 1);
            screen1.GetComponent<Image>().sprite = Resources.Load<Sprite>("数字2");
            screen1.GetComponent<Image>().SetNativeSize();
            ClickCaunt2++;
        }

        else if (ClickCaunt2 == 2)
        {
            screen1 = GameObject.Find("Canvas").gameObject.transform.Find("Tennkey").gameObject.transform.Find("screen").gameObject.transform.Find("screen3").gameObject;
            screen1.GetComponent<RectTransform>().localScale = new Vector3(1.5f, 0.7f, 1);
            screen1.GetComponent<Image>().sprite = Resources.Load<Sprite>("数字2");
            screen1.GetComponent<Image>().SetNativeSize();
            ClickCaunt2++;
        }

        else if (ClickCaunt2 == 3)
        {
            screen1 = GameObject.Find("Canvas").gameObject.transform.Find("Tennkey").gameObject.transform.Find("screen").gameObject.transform.Find("screen4").gameObject;
            screen1.GetComponent<RectTransform>().localScale = new Vector3(1.5f, 0.7f, 1);
            screen1.GetComponent<Image>().sprite = Resources.Load<Sprite>("数字2");
            screen1.GetComponent<Image>().SetNativeSize();
            ClickCaunt2++;
        }
    }

    public void OnButtonClick3()
    {
        

        if (ClickCaunt3 == 0)
        {
            screen1 = GameObject.Find("Canvas").gameObject.transform.Find("Tennkey").gameObject.transform.Find("screen").gameObject.transform.Find("screen1").gameObject;
            screen1.GetComponent<RectTransform>().localScale = new Vector3(1.5f, 0.7f, 1);
            screen1.GetComponent<Image>().sprite = Resources.Load<Sprite>("数字3");
            screen1.GetComponent<Image>().SetNativeSize();
            ClickCaunt3++;
        }

        else if (ClickCaunt3 == 1)
        {
            screen1 = GameObject.Find("Canvas").gameObject.transform.Find("Tennkey").gameObject.transform.Find("screen").gameObject.transform.Find("screen2").gameObject;
            screen1.GetComponent<RectTransform>().localScale = new Vector3(1.5f, 0.7f, 1);
            screen1.GetComponent<Image>().sprite = Resources.Load<Sprite>("数字3");
            screen1.GetComponent<Image>().SetNativeSize();
            ClickCaunt3++;
        }

        else if (ClickCaunt3 == 2)
        {
            screen1 = GameObject.Find("Canvas").gameObject.transform.Find("Tennkey").gameObject.transform.Find("screen").gameObject.transform.Find("screen3").gameObject;
            screen1.GetComponent<RectTransform>().localScale = new Vector3(1.5f, 0.7f, 1);
            screen1.GetComponent<Image>().sprite = Resources.Load<Sprite>("数字3");
            screen1.GetComponent<Image>().SetNativeSize();
            ClickCaunt3++;
        }

        else if (ClickCaunt3 == 3)
        {
            screen1 = GameObject.Find("Canvas").gameObject.transform.Find("Tennkey").gameObject.transform.Find("screen").gameObject.transform.Find("screen4").gameObject;
            screen1.GetComponent<RectTransform>().localScale = new Vector3(1.5f, 0.7f, 1);
            screen1.GetComponent<Image>().sprite = Resources.Load<Sprite>("数字3");
            screen1.GetComponent<Image>().SetNativeSize();
            ClickCaunt3++;
        }
    }

    public void OnButtonClick4()
    {
      
        if (ClickCaunt4 == 0)
        {
            screen1 = GameObject.Find("Canvas").gameObject.transform.Find("Tennkey").gameObject.transform.Find("screen").gameObject.transform.Find("screen1").gameObject;
            screen1.GetComponent<RectTransform>().localScale = new Vector3(1.5f, 0.7f, 1);
            screen1.GetComponent<Image>().sprite = Resources.Load<Sprite>("数字4");
            screen1.GetComponent<Image>().SetNativeSize();
            ClickCaunt4++;
        }

        else if (ClickCaunt4 == 1)
        {
            screen1 = GameObject.Find("Canvas").gameObject.transform.Find("Tennkey").gameObject.transform.Find("screen").gameObject.transform.Find("screen2").gameObject;
            screen1.GetComponent<RectTransform>().localScale = new Vector3(1.5f, 0.7f, 1);
            screen1.GetComponent<Image>().sprite = Resources.Load<Sprite>("数字4");
            screen1.GetComponent<Image>().SetNativeSize();
            ClickCaunt4++;
        }

        else if (ClickCaunt4 == 2)
        {
            screen1 = GameObject.Find("Canvas").gameObject.transform.Find("Tennkey").gameObject.transform.Find("screen").gameObject.transform.Find("screen3").gameObject;
            screen1.GetComponent<RectTransform>().localScale = new Vector3(1.5f, 0.7f, 1);
            screen1.GetComponent<Image>().sprite = Resources.Load<Sprite>("数字4");
            screen1.GetComponent<Image>().SetNativeSize();
            ClickCaunt4++;
        }

        else if (ClickCaunt4 == 3)
        {
            screen1 = GameObject.Find("Canvas").gameObject.transform.Find("Tennkey").gameObject.transform.Find("screen").gameObject.transform.Find("screen4").gameObject;
            screen1.GetComponent<RectTransform>().localScale = new Vector3(1.5f, 0.7f, 1);
            screen1.GetComponent<Image>().sprite = Resources.Load<Sprite>("数字4");
            screen1.GetComponent<Image>().SetNativeSize();
            ClickCaunt4++;
        }
    }

    public void OnButtonClick5()
    {
        
        if (ClickCaunt5 == 0)
        {
            screen1 = GameObject.Find("Canvas").gameObject.transform.Find("Tennkey").gameObject.transform.Find("screen").gameObject.transform.Find("screen1").gameObject;
            screen1.GetComponent<RectTransform>().localScale = new Vector3(1.5f, 0.7f, 1);
            screen1.GetComponent<Image>().sprite = Resources.Load<Sprite>("数字5");
            screen1.GetComponent<Image>().SetNativeSize();
            ClickCaunt5++;
        }

        else if (ClickCaunt5 == 1)
        {
            screen1 = GameObject.Find("Canvas").gameObject.transform.Find("Tennkey").gameObject.transform.Find("screen").gameObject.transform.Find("screen2").gameObject;
            screen1.GetComponent<RectTransform>().localScale = new Vector3(1.5f, 0.7f, 1);
            screen1.GetComponent<Image>().sprite = Resources.Load<Sprite>("数字5");
            screen1.GetComponent<Image>().SetNativeSize();
            ClickCaunt5++;
        }

        else if (ClickCaunt5 == 2)
        {
            screen1 = GameObject.Find("Canvas").gameObject.transform.Find("Tennkey").gameObject.transform.Find("screen").gameObject.transform.Find("screen3").gameObject;
            screen1.GetComponent<RectTransform>().localScale = new Vector3(1.5f, 0.7f, 1);
            screen1.GetComponent<Image>().sprite = Resources.Load<Sprite>("数字5");
            screen1.GetComponent<Image>().SetNativeSize();
            ClickCaunt5++;
        }

        else if (ClickCaunt5 == 3)
        {
            screen1 = GameObject.Find("Canvas").gameObject.transform.Find("Tennkey").gameObject.transform.Find("screen").gameObject.transform.Find("screen4").gameObject;
            screen1.GetComponent<RectTransform>().localScale = new Vector3(1.5f, 0.7f, 1);
            screen1.GetComponent<Image>().sprite = Resources.Load<Sprite>("数字5");
            screen1.GetComponent<Image>().SetNativeSize();
            ClickCaunt5++;
        }
    }

    public void OnButtonClick6()
    {
       

        if (ClickCaunt6 == 0)
        {
            screen1 = GameObject.Find("Canvas").gameObject.transform.Find("Tennkey").gameObject.transform.Find("screen").gameObject.transform.Find("screen1").gameObject;
            screen1.GetComponent<RectTransform>().localScale = new Vector3(1.5f, 0.7f, 1);
            screen1.GetComponent<Image>().sprite = Resources.Load<Sprite>("数字6");
            screen1.GetComponent<Image>().SetNativeSize();
            ClickCaunt6++;
        }

        else if (ClickCaunt6 == 1)
        {
            screen1 = GameObject.Find("Canvas").gameObject.transform.Find("Tennkey").gameObject.transform.Find("screen").gameObject.transform.Find("screen2").gameObject;
            screen1.GetComponent<RectTransform>().localScale = new Vector3(1.5f, 0.7f, 1);
            screen1.GetComponent<Image>().sprite = Resources.Load<Sprite>("数字6");
            screen1.GetComponent<Image>().SetNativeSize();
            ClickCaunt6++;
        }

        else if (ClickCaunt6 == 2)
        {
            screen1 = GameObject.Find("Canvas").gameObject.transform.Find("Tennkey").gameObject.transform.Find("screen").gameObject.transform.Find("screen3").gameObject;
            screen1.GetComponent<RectTransform>().localScale = new Vector3(1.5f, 0.7f, 1);
            screen1.GetComponent<Image>().sprite = Resources.Load<Sprite>("数字6");
            screen1.GetComponent<Image>().SetNativeSize();
            ClickCaunt6++;
        }

        else if (ClickCaunt6 == 3)
        {
            screen1 = GameObject.Find("Canvas").gameObject.transform.Find("Tennkey").gameObject.transform.Find("screen").gameObject.transform.Find("screen4").gameObject;
            screen1.GetComponent<RectTransform>().localScale = new Vector3(1.5f, 0.7f, 1);
            screen1.GetComponent<Image>().sprite = Resources.Load<Sprite>("数字6");
            screen1.GetComponent<Image>().SetNativeSize();
            ClickCaunt6++;
        }
    }

    public void OnButtonClick7()
    {

        if (ClickCaunt7 == 0)
        {
            screen1 = GameObject.Find("Canvas").gameObject.transform.Find("Tennkey").gameObject.transform.Find("screen").gameObject.transform.Find("screen1").gameObject;
            screen1.GetComponent<RectTransform>().localScale = new Vector3(1.5f, 0.7f, 1);
            screen1.GetComponent<Image>().sprite = Resources.Load<Sprite>("数字7");
            screen1.GetComponent<Image>().SetNativeSize();
            ClickCaunt7++;
        }

        else if (ClickCaunt7 == 1)
        {
            screen1 = GameObject.Find("Canvas").gameObject.transform.Find("Tennkey").gameObject.transform.Find("screen").gameObject.transform.Find("screen2").gameObject;
            screen1.GetComponent<RectTransform>().localScale = new Vector3(1.5f, 0.7f, 1);
            screen1.GetComponent<Image>().sprite = Resources.Load<Sprite>("数字7");
            screen1.GetComponent<Image>().SetNativeSize();
            ClickCaunt7++;
        }

        else if (ClickCaunt7 == 2)
        {
            screen1 = GameObject.Find("Canvas").gameObject.transform.Find("Tennkey").gameObject.transform.Find("screen").gameObject.transform.Find("screen3").gameObject;
            screen1.GetComponent<RectTransform>().localScale = new Vector3(1.5f, 0.7f, 1);
            screen1.GetComponent<Image>().sprite = Resources.Load<Sprite>("数字7");
            screen1.GetComponent<Image>().SetNativeSize();
            ClickCaunt7++;
        }

        else if (ClickCaunt7 == 3)
        {
            screen1 = GameObject.Find("Canvas").gameObject.transform.Find("Tennkey").gameObject.transform.Find("screen").gameObject.transform.Find("screen4").gameObject;
            screen1.GetComponent<RectTransform>().localScale = new Vector3(1.5f, 0.7f, 1);
            screen1.GetComponent<Image>().sprite = Resources.Load<Sprite>("数字7");
            screen1.GetComponent<Image>().SetNativeSize();
            ClickCaunt7++;
        }
    }

    public void OnButtonClick8()
    {
      
        if (ClickCaunt8 == 0)
        {
            screen1 = GameObject.Find("Canvas").gameObject.transform.Find("Tennkey").gameObject.transform.Find("screen").gameObject.transform.Find("screen1").gameObject;
            screen1.GetComponent<RectTransform>().localScale = new Vector3(1.5f, 0.7f, 1);
            screen1.GetComponent<Image>().sprite = Resources.Load<Sprite>("数字8");
            screen1.GetComponent<Image>().SetNativeSize();
            ClickCaunt8++;
        }

        else if (ClickCaunt8 == 1)
        {
            screen1 = GameObject.Find("Canvas").gameObject.transform.Find("Tennkey").gameObject.transform.Find("screen").gameObject.transform.Find("screen2").gameObject;
            screen1.GetComponent<RectTransform>().localScale = new Vector3(1.5f, 0.7f, 1);
            screen1.GetComponent<Image>().sprite = Resources.Load<Sprite>("数字8");
            screen1.GetComponent<Image>().SetNativeSize();
            ClickCaunt8++;
        }

        else if (ClickCaunt8 == 2)
        {
            screen1 = GameObject.Find("Canvas").gameObject.transform.Find("Tennkey").gameObject.transform.Find("screen").gameObject.transform.Find("screen3").gameObject;
            screen1.GetComponent<RectTransform>().localScale = new Vector3(1.5f, 0.7f, 1);
            screen1.GetComponent<Image>().sprite = Resources.Load<Sprite>("数字8");
            screen1.GetComponent<Image>().SetNativeSize();
            ClickCaunt8++;
        }

        else if (ClickCaunt8 == 3)
        {
            screen1 = GameObject.Find("Canvas").gameObject.transform.Find("Tennkey").gameObject.transform.Find("screen").gameObject.transform.Find("screen4").gameObject;
            screen1.GetComponent<RectTransform>().localScale = new Vector3(1.5f, 0.7f, 1);
            screen1.GetComponent<Image>().sprite = Resources.Load<Sprite>("数字8");
            screen1.GetComponent<Image>().SetNativeSize();
            ClickCaunt8++;
        }
    }

    public void OnButtonClick9()
    {

        if (ClickCaunt9 == 0)
        {
            screen1 = GameObject.Find("Canvas").gameObject.transform.Find("Tennkey").gameObject.transform.Find("screen").gameObject.transform.Find("screen1").gameObject;
            screen1.GetComponent<RectTransform>().localScale = new Vector3(1.5f, 0.7f, 1);
            screen1.GetComponent<Image>().sprite = Resources.Load<Sprite>("数字9");
            screen1.GetComponent<Image>().SetNativeSize();
            ClickCaunt9++;
        }

        else if (ClickCaunt9 == 1)
        {
            screen1 = GameObject.Find("Canvas").gameObject.transform.Find("Tennkey").gameObject.transform.Find("screen").gameObject.transform.Find("screen2").gameObject;
            screen1.GetComponent<RectTransform>().localScale = new Vector3(1.5f, 0.7f, 1);
            screen1.GetComponent<Image>().sprite = Resources.Load<Sprite>("数字9");
            screen1.GetComponent<Image>().SetNativeSize();
            ClickCaunt9++;
        }

        else if (ClickCaunt9 == 2)
        {
            screen1 = GameObject.Find("Canvas").gameObject.transform.Find("Tennkey").gameObject.transform.Find("screen").gameObject.transform.Find("screen3").gameObject;
            screen1.GetComponent<RectTransform>().localScale = new Vector3(1.5f, 0.7f, 1);
            screen1.GetComponent<Image>().sprite = Resources.Load<Sprite>("数字9");
            screen1.GetComponent<Image>().SetNativeSize();
            ClickCaunt9++;
        }

        else if (ClickCaunt9== 3)
        {
            screen1 = GameObject.Find("Canvas").gameObject.transform.Find("Tennkey").gameObject.transform.Find("screen").gameObject.transform.Find("screen4").gameObject;
            screen1.GetComponent<RectTransform>().localScale = new Vector3(1.5f, 0.7f, 1);
            screen1.GetComponent<Image>().sprite = Resources.Load<Sprite>("数字9");
            screen1.GetComponent<Image>().SetNativeSize();
            ClickCaunt9++;
        }
    }

    public void OnButtonClick0()
    {
  
        if (ClickCaunt0 == 0)
        {
            screen1 = GameObject.Find("Canvas").gameObject.transform.Find("Tennkey").gameObject.transform.Find("screen").gameObject.transform.Find("screen1").gameObject;
            screen1.GetComponent<RectTransform>().localScale = new Vector3(1.5f, 0.7f, 1);
            screen1.GetComponent<Image>().sprite = Resources.Load<Sprite>("数字0");
            screen1.GetComponent<Image>().SetNativeSize();
            ClickCaunt0++;
        }

        else if (ClickCaunt0 == 1)
        {
            screen1 = GameObject.Find("Canvas").gameObject.transform.Find("Tennkey").gameObject.transform.Find("screen").gameObject.transform.Find("screen2").gameObject;
            screen1.GetComponent<RectTransform>().localScale = new Vector3(1.5f, 0.7f, 1);
            screen1.GetComponent<Image>().sprite = Resources.Load<Sprite>("数字0");
            screen1.GetComponent<Image>().SetNativeSize();
            ClickCaunt0++;
        }

        else if (ClickCaunt0 == 2)
        {
            screen1 = GameObject.Find("Canvas").gameObject.transform.Find("Tennkey").gameObject.transform.Find("screen").gameObject.transform.Find("screen3").gameObject;
            screen1.GetComponent<RectTransform>().localScale = new Vector3(1.5f, 0.7f, 1);
            screen1.GetComponent<Image>().sprite = Resources.Load<Sprite>("数字0");
            screen1.GetComponent<Image>().SetNativeSize();
            ClickCaunt0++;
        }

        else if (ClickCaunt0 == 3)
        {
            screen1 = GameObject.Find("Canvas").gameObject.transform.Find("Tennkey").gameObject.transform.Find("screen").gameObject.transform.Find("screen4").gameObject;
            screen1.GetComponent<RectTransform>().localScale = new Vector3(1.5f, 0.7f, 1);
            screen1.GetComponent<Image>().sprite = Resources.Load<Sprite>("数字0");
            screen1.GetComponent<Image>().SetNativeSize();
            ClickCaunt0++;
        }
    }

   /* public void OnButtonClick_ok()
    {
   
        if (ClickCaunt0 == 4 && ClickCaunt8 == 3)
        {
            
        }

    }*/

    public void OnButtonClick_cancel()
    {
        ClickCaunt0 = 0;
        ClickCaunt1 = 0;
        ClickCaunt2 = 0;
        ClickCaunt3 = 0;
        ClickCaunt4 = 0;
        ClickCaunt5 = 0;
        ClickCaunt6 = 0;
        ClickCaunt7 = 0;
        ClickCaunt8 = 0;
        ClickCaunt9 = 0;
    }

    // Update is called once per frame
    void Update () {

       
	}
}

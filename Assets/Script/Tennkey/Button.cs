using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button : MonoBehaviour {


    public GameObject screen1;
    static int ClickCaunt = 0;
    static bool k = false;
    static bool i = false;
    

    // Use this for initialization
    void Start () {
		
	}


    public void OnButtonClick1()
    {
       

        if (ClickCaunt == 0 )
        {
            screen1 = GameObject.Find("Canvas").gameObject.transform.Find("Tennkey").gameObject.transform.Find("screen").gameObject.transform.Find("screen1").gameObject;
            screen1.GetComponent<RectTransform>().localScale = new Vector3(1.5f, 0.7f, 1);
            screen1.GetComponent<Image>().sprite = Resources.Load<Sprite>("数字1");
            screen1.GetComponent<Image>().SetNativeSize();
            ClickCaunt++;
        }
        
        else if (ClickCaunt== 1 )
        {
            screen1 = GameObject.Find("Canvas").gameObject.transform.Find("Tennkey").gameObject.transform.Find("screen").gameObject.transform.Find("screen2").gameObject;
            screen1.GetComponent<RectTransform>().localScale = new Vector3(1.5f, 0.7f, 1);
            screen1.GetComponent<Image>().sprite = Resources.Load<Sprite>("数字1");
            screen1.GetComponent<Image>().SetNativeSize();
            ClickCaunt++;
        }

        else if (ClickCaunt == 2 )
        {
            screen1 = GameObject.Find("Canvas").gameObject.transform.Find("Tennkey").gameObject.transform.Find("screen").gameObject.transform.Find("screen3").gameObject;
            screen1.GetComponent<RectTransform>().localScale = new Vector3(1.5f, 0.7f, 1);
            screen1.GetComponent<Image>().sprite = Resources.Load<Sprite>("数字1");
            screen1.GetComponent<Image>().SetNativeSize();
            ClickCaunt++;
        }

        else if (ClickCaunt == 3 )
        {
            screen1 = GameObject.Find("Canvas").gameObject.transform.Find("Tennkey").gameObject.transform.Find("screen").gameObject.transform.Find("screen4").gameObject;
            screen1.GetComponent<RectTransform>().localScale = new Vector3(1.5f, 0.7f, 1);
            screen1.GetComponent<Image>().sprite = Resources.Load<Sprite>("数字1");
            screen1.GetComponent<Image>().SetNativeSize();
            ClickCaunt++;
        }
    }

    public void OnButtonClick2()
    {
       
        if (ClickCaunt == 0)
        {
            screen1 = GameObject.Find("Canvas").gameObject.transform.Find("Tennkey").gameObject.transform.Find("screen").gameObject.transform.Find("screen1").gameObject;
            screen1.GetComponent<RectTransform>().localScale = new Vector3(1.5f, 0.7f, 1);
            screen1.GetComponent<Image>().sprite = Resources.Load<Sprite>("数字2");
            screen1.GetComponent<Image>().SetNativeSize();
            ClickCaunt++;
        }

        else if (ClickCaunt == 1)
        {
            screen1 = GameObject.Find("Canvas").gameObject.transform.Find("Tennkey").gameObject.transform.Find("screen").gameObject.transform.Find("screen2").gameObject;
            screen1.GetComponent<RectTransform>().localScale = new Vector3(1.5f, 0.7f, 1);
            screen1.GetComponent<Image>().sprite = Resources.Load<Sprite>("数字2");
            screen1.GetComponent<Image>().SetNativeSize();
            ClickCaunt++;
        }

        else if (ClickCaunt == 2)
        {
            screen1 = GameObject.Find("Canvas").gameObject.transform.Find("Tennkey").gameObject.transform.Find("screen").gameObject.transform.Find("screen3").gameObject;
            screen1.GetComponent<RectTransform>().localScale = new Vector3(1.5f, 0.7f, 1);
            screen1.GetComponent<Image>().sprite = Resources.Load<Sprite>("数字2");
            screen1.GetComponent<Image>().SetNativeSize();
            ClickCaunt++;
        }

        else if (ClickCaunt == 3)
        {
            screen1 = GameObject.Find("Canvas").gameObject.transform.Find("Tennkey").gameObject.transform.Find("screen").gameObject.transform.Find("screen4").gameObject;
            screen1.GetComponent<RectTransform>().localScale = new Vector3(1.5f, 0.7f, 1);
            screen1.GetComponent<Image>().sprite = Resources.Load<Sprite>("数字2");
            screen1.GetComponent<Image>().SetNativeSize();
            ClickCaunt++;
        }
    }

    public void OnButtonClick3()
    {
        

        if (ClickCaunt == 0)
        {
            screen1 = GameObject.Find("Canvas").gameObject.transform.Find("Tennkey").gameObject.transform.Find("screen").gameObject.transform.Find("screen1").gameObject;
            screen1.GetComponent<RectTransform>().localScale = new Vector3(1.5f, 0.7f, 1);
            screen1.GetComponent<Image>().sprite = Resources.Load<Sprite>("数字3");
            screen1.GetComponent<Image>().SetNativeSize();
            ClickCaunt++;
        }

        else if (ClickCaunt == 1)
        {
            screen1 = GameObject.Find("Canvas").gameObject.transform.Find("Tennkey").gameObject.transform.Find("screen").gameObject.transform.Find("screen2").gameObject;
            screen1.GetComponent<RectTransform>().localScale = new Vector3(1.5f, 0.7f, 1);
            screen1.GetComponent<Image>().sprite = Resources.Load<Sprite>("数字3");
            screen1.GetComponent<Image>().SetNativeSize();
            ClickCaunt++;
        }

        else if (ClickCaunt == 2)
        {
            screen1 = GameObject.Find("Canvas").gameObject.transform.Find("Tennkey").gameObject.transform.Find("screen").gameObject.transform.Find("screen3").gameObject;
            screen1.GetComponent<RectTransform>().localScale = new Vector3(1.5f, 0.7f, 1);
            screen1.GetComponent<Image>().sprite = Resources.Load<Sprite>("数字3");
            screen1.GetComponent<Image>().SetNativeSize();
            ClickCaunt++;
        }

        else if (ClickCaunt == 3)
        {
            screen1 = GameObject.Find("Canvas").gameObject.transform.Find("Tennkey").gameObject.transform.Find("screen").gameObject.transform.Find("screen4").gameObject;
            screen1.GetComponent<RectTransform>().localScale = new Vector3(1.5f, 0.7f, 1);
            screen1.GetComponent<Image>().sprite = Resources.Load<Sprite>("数字3");
            screen1.GetComponent<Image>().SetNativeSize();
            ClickCaunt++;
        }
    }

    public void OnButtonClick4()
    {
      
        if (ClickCaunt == 0)
        {
            screen1 = GameObject.Find("Canvas").gameObject.transform.Find("Tennkey").gameObject.transform.Find("screen").gameObject.transform.Find("screen1").gameObject;
            screen1.GetComponent<RectTransform>().localScale = new Vector3(1.5f, 0.7f, 1);
            screen1.GetComponent<Image>().sprite = Resources.Load<Sprite>("数字4");
            screen1.GetComponent<Image>().SetNativeSize();
            ClickCaunt++;
        }

        else if (ClickCaunt == 1)
        {
            screen1 = GameObject.Find("Canvas").gameObject.transform.Find("Tennkey").gameObject.transform.Find("screen").gameObject.transform.Find("screen2").gameObject;
            screen1.GetComponent<RectTransform>().localScale = new Vector3(1.5f, 0.7f, 1);
            screen1.GetComponent<Image>().sprite = Resources.Load<Sprite>("数字4");
            screen1.GetComponent<Image>().SetNativeSize();
            ClickCaunt++;
        }

        else if (ClickCaunt == 2)
        {
            screen1 = GameObject.Find("Canvas").gameObject.transform.Find("Tennkey").gameObject.transform.Find("screen").gameObject.transform.Find("screen3").gameObject;
            screen1.GetComponent<RectTransform>().localScale = new Vector3(1.5f, 0.7f, 1);
            screen1.GetComponent<Image>().sprite = Resources.Load<Sprite>("数字4");
            screen1.GetComponent<Image>().SetNativeSize();
            ClickCaunt++;
        }

        else if (ClickCaunt == 3)
        {
            screen1 = GameObject.Find("Canvas").gameObject.transform.Find("Tennkey").gameObject.transform.Find("screen").gameObject.transform.Find("screen4").gameObject;
            screen1.GetComponent<RectTransform>().localScale = new Vector3(1.5f, 0.7f, 1);
            screen1.GetComponent<Image>().sprite = Resources.Load<Sprite>("数字4");
            screen1.GetComponent<Image>().SetNativeSize();
            ClickCaunt++;
        }
    }

    public void OnButtonClick5()
    {
        
        if (ClickCaunt == 0)
        {
            screen1 = GameObject.Find("Canvas").gameObject.transform.Find("Tennkey").gameObject.transform.Find("screen").gameObject.transform.Find("screen1").gameObject;
            screen1.GetComponent<RectTransform>().localScale = new Vector3(1.5f, 0.7f, 1);
            screen1.GetComponent<Image>().sprite = Resources.Load<Sprite>("数字5");
            screen1.GetComponent<Image>().SetNativeSize();
            ClickCaunt++;
        }

        else if (ClickCaunt == 1)
        {
            screen1 = GameObject.Find("Canvas").gameObject.transform.Find("Tennkey").gameObject.transform.Find("screen").gameObject.transform.Find("screen2").gameObject;
            screen1.GetComponent<RectTransform>().localScale = new Vector3(1.5f, 0.7f, 1);
            screen1.GetComponent<Image>().sprite = Resources.Load<Sprite>("数字5");
            screen1.GetComponent<Image>().SetNativeSize();
            ClickCaunt++;
        }

        else if (ClickCaunt == 2)
        {
            screen1 = GameObject.Find("Canvas").gameObject.transform.Find("Tennkey").gameObject.transform.Find("screen").gameObject.transform.Find("screen3").gameObject;
            screen1.GetComponent<RectTransform>().localScale = new Vector3(1.5f, 0.7f, 1);
            screen1.GetComponent<Image>().sprite = Resources.Load<Sprite>("数字5");
            screen1.GetComponent<Image>().SetNativeSize();
            ClickCaunt++;
        }

        else if (ClickCaunt == 3)
        {
            screen1 = GameObject.Find("Canvas").gameObject.transform.Find("Tennkey").gameObject.transform.Find("screen").gameObject.transform.Find("screen4").gameObject;
            screen1.GetComponent<RectTransform>().localScale = new Vector3(1.5f, 0.7f, 1);
            screen1.GetComponent<Image>().sprite = Resources.Load<Sprite>("数字5");
            screen1.GetComponent<Image>().SetNativeSize();
            ClickCaunt++;
        }
    }

    public void OnButtonClick6()
    {
       

        if (ClickCaunt == 0)
        {
            screen1 = GameObject.Find("Canvas").gameObject.transform.Find("Tennkey").gameObject.transform.Find("screen").gameObject.transform.Find("screen1").gameObject;
            screen1.GetComponent<RectTransform>().localScale = new Vector3(1.5f, 0.7f, 1);
            screen1.GetComponent<Image>().sprite = Resources.Load<Sprite>("数字6");
            screen1.GetComponent<Image>().SetNativeSize();
            ClickCaunt++;
        }

        else if (ClickCaunt == 1)
        {
            screen1 = GameObject.Find("Canvas").gameObject.transform.Find("Tennkey").gameObject.transform.Find("screen").gameObject.transform.Find("screen2").gameObject;
            screen1.GetComponent<RectTransform>().localScale = new Vector3(1.5f, 0.7f, 1);
            screen1.GetComponent<Image>().sprite = Resources.Load<Sprite>("数字6");
            screen1.GetComponent<Image>().SetNativeSize();
            ClickCaunt++;
        }

        else if (ClickCaunt == 2)
        {
            screen1 = GameObject.Find("Canvas").gameObject.transform.Find("Tennkey").gameObject.transform.Find("screen").gameObject.transform.Find("screen3").gameObject;
            screen1.GetComponent<RectTransform>().localScale = new Vector3(1.5f, 0.7f, 1);
            screen1.GetComponent<Image>().sprite = Resources.Load<Sprite>("数字6");
            screen1.GetComponent<Image>().SetNativeSize();
            ClickCaunt++;
        }

        else if (ClickCaunt == 3)
        {
            screen1 = GameObject.Find("Canvas").gameObject.transform.Find("Tennkey").gameObject.transform.Find("screen").gameObject.transform.Find("screen4").gameObject;
            screen1.GetComponent<RectTransform>().localScale = new Vector3(1.5f, 0.7f, 1);
            screen1.GetComponent<Image>().sprite = Resources.Load<Sprite>("数字6");
            screen1.GetComponent<Image>().SetNativeSize();
            ClickCaunt++;
        }
    }

    public void OnButtonClick7()
    {

        if (ClickCaunt == 0)
        {
            screen1 = GameObject.Find("Canvas").gameObject.transform.Find("Tennkey").gameObject.transform.Find("screen").gameObject.transform.Find("screen1").gameObject;
            screen1.GetComponent<RectTransform>().localScale = new Vector3(1.5f, 0.7f, 1);
            screen1.GetComponent<Image>().sprite = Resources.Load<Sprite>("数字7");
            screen1.GetComponent<Image>().SetNativeSize();
            ClickCaunt++;
        }

        else if (ClickCaunt == 1)
        {
            screen1 = GameObject.Find("Canvas").gameObject.transform.Find("Tennkey").gameObject.transform.Find("screen").gameObject.transform.Find("screen2").gameObject;
            screen1.GetComponent<RectTransform>().localScale = new Vector3(1.5f, 0.7f, 1);
            screen1.GetComponent<Image>().sprite = Resources.Load<Sprite>("数字7");
            screen1.GetComponent<Image>().SetNativeSize();
            ClickCaunt++;
        }

        else if (ClickCaunt == 2)
        {
            screen1 = GameObject.Find("Canvas").gameObject.transform.Find("Tennkey").gameObject.transform.Find("screen").gameObject.transform.Find("screen3").gameObject;
            screen1.GetComponent<RectTransform>().localScale = new Vector3(1.5f, 0.7f, 1);
            screen1.GetComponent<Image>().sprite = Resources.Load<Sprite>("数字7");
            screen1.GetComponent<Image>().SetNativeSize();
            ClickCaunt++;
        }

        else if (ClickCaunt == 3)
        {
            screen1 = GameObject.Find("Canvas").gameObject.transform.Find("Tennkey").gameObject.transform.Find("screen").gameObject.transform.Find("screen4").gameObject;
            screen1.GetComponent<RectTransform>().localScale = new Vector3(1.5f, 0.7f, 1);
            screen1.GetComponent<Image>().sprite = Resources.Load<Sprite>("数字7");
            screen1.GetComponent<Image>().SetNativeSize();
            ClickCaunt++;
        }
    }

    public void OnButtonClick8()
    {
      
        if (ClickCaunt == 0)
        {
            screen1 = GameObject.Find("Canvas").gameObject.transform.Find("Tennkey").gameObject.transform.Find("screen").gameObject.transform.Find("screen1").gameObject;
            screen1.GetComponent<RectTransform>().localScale = new Vector3(1.5f, 0.7f, 1);
            screen1.GetComponent<Image>().sprite = Resources.Load<Sprite>("数字8");
            screen1.GetComponent<Image>().SetNativeSize();
            ClickCaunt++;
        }

        else if (ClickCaunt == 1)
        {
            screen1 = GameObject.Find("Canvas").gameObject.transform.Find("Tennkey").gameObject.transform.Find("screen").gameObject.transform.Find("screen2").gameObject;
            screen1.GetComponent<RectTransform>().localScale = new Vector3(1.5f, 0.7f, 1);
            screen1.GetComponent<Image>().sprite = Resources.Load<Sprite>("数字8");
            screen1.GetComponent<Image>().SetNativeSize();
            ClickCaunt++;
        }

        else if (ClickCaunt == 2)
        {
            screen1 = GameObject.Find("Canvas").gameObject.transform.Find("Tennkey").gameObject.transform.Find("screen").gameObject.transform.Find("screen3").gameObject;
            screen1.GetComponent<RectTransform>().localScale = new Vector3(1.5f, 0.7f, 1);
            screen1.GetComponent<Image>().sprite = Resources.Load<Sprite>("数字8");
            screen1.GetComponent<Image>().SetNativeSize();
            ClickCaunt++;
            k = true;
        }

        else if (ClickCaunt == 3)
        {
            screen1 = GameObject.Find("Canvas").gameObject.transform.Find("Tennkey").gameObject.transform.Find("screen").gameObject.transform.Find("screen4").gameObject;
            screen1.GetComponent<RectTransform>().localScale = new Vector3(1.5f, 0.7f, 1);
            screen1.GetComponent<Image>().sprite = Resources.Load<Sprite>("数字8");
            screen1.GetComponent<Image>().SetNativeSize();
            ClickCaunt++;
        }
    }

    public void OnButtonClick9()
    {

        if (ClickCaunt == 0)
        {
            screen1 = GameObject.Find("Canvas").gameObject.transform.Find("Tennkey").gameObject.transform.Find("screen").gameObject.transform.Find("screen1").gameObject;
            screen1.GetComponent<RectTransform>().localScale = new Vector3(1.5f, 0.7f, 1);
            screen1.GetComponent<Image>().sprite = Resources.Load<Sprite>("数字9");
            screen1.GetComponent<Image>().SetNativeSize();
            ClickCaunt++;
        }

        else if (ClickCaunt == 1)
        {
            screen1 = GameObject.Find("Canvas").gameObject.transform.Find("Tennkey").gameObject.transform.Find("screen").gameObject.transform.Find("screen2").gameObject;
            screen1.GetComponent<RectTransform>().localScale = new Vector3(1.5f, 0.7f, 1);
            screen1.GetComponent<Image>().sprite = Resources.Load<Sprite>("数字9");
            screen1.GetComponent<Image>().SetNativeSize();
            ClickCaunt++;
        }

        else if (ClickCaunt == 2)
        {
            screen1 = GameObject.Find("Canvas").gameObject.transform.Find("Tennkey").gameObject.transform.Find("screen").gameObject.transform.Find("screen3").gameObject;
            screen1.GetComponent<RectTransform>().localScale = new Vector3(1.5f, 0.7f, 1);
            screen1.GetComponent<Image>().sprite = Resources.Load<Sprite>("数字9");
            screen1.GetComponent<Image>().SetNativeSize();
            ClickCaunt++;
        }

        else if (ClickCaunt== 3)
        {
            screen1 = GameObject.Find("Canvas").gameObject.transform.Find("Tennkey").gameObject.transform.Find("screen").gameObject.transform.Find("screen4").gameObject;
            screen1.GetComponent<RectTransform>().localScale = new Vector3(1.5f, 0.7f, 1);
            screen1.GetComponent<Image>().sprite = Resources.Load<Sprite>("数字9");
            screen1.GetComponent<Image>().SetNativeSize();
            ClickCaunt++;
        }
    }

    public void OnButtonClick0()
    {
  
        if (ClickCaunt == 0)
        {
            screen1 = GameObject.Find("Canvas").gameObject.transform.Find("Tennkey").gameObject.transform.Find("screen").gameObject.transform.Find("screen1").gameObject;
            screen1.GetComponent<RectTransform>().localScale = new Vector3(1.5f, 0.7f, 1);
            screen1.GetComponent<Image>().sprite = Resources.Load<Sprite>("数字0");
            screen1.GetComponent<Image>().SetNativeSize();
            ClickCaunt++;
        }

        else if (ClickCaunt == 1)
        {
            screen1 = GameObject.Find("Canvas").gameObject.transform.Find("Tennkey").gameObject.transform.Find("screen").gameObject.transform.Find("screen2").gameObject;
            screen1.GetComponent<RectTransform>().localScale = new Vector3(1.5f, 0.7f, 1);
            screen1.GetComponent<Image>().sprite = Resources.Load<Sprite>("数字0");
            screen1.GetComponent<Image>().SetNativeSize();
            ClickCaunt++;
        }

        else if (ClickCaunt == 2)
        {
            screen1 = GameObject.Find("Canvas").gameObject.transform.Find("Tennkey").gameObject.transform.Find("screen").gameObject.transform.Find("screen3").gameObject;
            screen1.GetComponent<RectTransform>().localScale = new Vector3(1.5f, 0.7f, 1);
            screen1.GetComponent<Image>().sprite = Resources.Load<Sprite>("数字0");
            screen1.GetComponent<Image>().SetNativeSize();
            ClickCaunt++;
        }

        else if (ClickCaunt == 3)
        {
            screen1 = GameObject.Find("Canvas").gameObject.transform.Find("Tennkey").gameObject.transform.Find("screen").gameObject.transform.Find("screen4").gameObject;
            screen1.GetComponent<RectTransform>().localScale = new Vector3(1.5f, 0.7f, 1);
            screen1.GetComponent<Image>().sprite = Resources.Load<Sprite>("数字0");
            screen1.GetComponent<Image>().SetNativeSize();
            ClickCaunt++;
            i = true;
        }
    }

    public void OnButtonClick_ok()
    {
   
        if (k == true && i == true)
        {
            GameObject Door = GameObject.Find("Tobira").gameObject;
            Quaternion q = Quaternion.Euler(0f, 0f, 90f);
            Door.transform.rotation = q;
            Vector3 v = Door.transform.localPosition;
            v.z -= 2.3f;
            Door.transform.localPosition = v;
            //count = false;
        }

    }

    public void OnButtonClick_cancel()
    {
        ClickCaunt = 0;
        k = false;
        i = false;
       
    }

    // Update is called once per frame
    void Update () {

       
	}
}

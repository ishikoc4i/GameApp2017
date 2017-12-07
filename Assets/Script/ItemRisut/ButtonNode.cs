using UnityEngine;
using UnityEngine.UI;

public class ButtonNode : MonoBehaviour
{
    public Text buttonText;

    public Image buttonIcon;

    public GameObject content;

    public Image hoge;

    public float x, y;

    // 押したら更新するText
    public Text DetailText;

    public void Initialize(string buttonString, Text DetailText)
    {

        this.buttonText.text = buttonString ;
        this.DetailText = DetailText;

    }

    public void OnButtonClick()
    {
        
        
        DetailText.text = buttonText.text;
        
    }

    public void SetImg(string imgName)
    {
        hoge = this.gameObject.transform.Find("Icon").GetComponent<Image>();
        hoge.sprite = Resources.Load<Sprite>(imgName);
        hoge.GetComponent<RectTransform>().localScale = new Vector2(0.55f, 0.55f);

    }
}
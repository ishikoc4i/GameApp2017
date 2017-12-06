using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class NodeManager : MonoBehaviour
{
    public Text DetailText;

    public GameObject node;
    public GameObject content;
    int count;
    int k;

    

    string[] itemlist = new string[] { "itemicon", "itemicon2", "itemicon3", "itemicon4", "itemicon3"};
    string[] buttonString = new string[] { "錆びた鍵\n\n\n所持数" , "エタノール\n\n\n所持数", "棚の鍵\n\n\n所持数", "電池\n\n\n所持数", "昇降口の鍵\n\n\n所持数" };
    

    void Start()
    {
        renderItems();
        
   
    }

    void renderItems()
    {
        // TODO: itemlistを初期化する処理

        for (int i = 0; i < itemlist.Length; i++)
        {
            var instance = Instantiate(node);
            instance.transform.SetParent(content.transform, false);

            var buttonNode = instance.GetComponent<ButtonNode>();

            buttonNode.Initialize(buttonString[i], DetailText);
            buttonNode.SetImg(itemlist[i]);
            
        }
    }
}
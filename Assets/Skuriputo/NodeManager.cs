using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class NodeManager : MonoBehaviour
{
    public Text detailText;

    public GameObject node;
    public GameObject content;

    void Start()
    {
        Enumerable.Range(1, 10).ToList().ForEach(x =>
        {
            var instance = Instantiate(node);
            instance.transform.SetParent(content.transform, false);

            var buttonNode = instance.GetComponent<ButtonNode>();
            buttonNode.Initialize("node" + x, detailText);
        });
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Syoukouguti_1 : MonoBehaviour
{
    public static bool count = true;
    public int Hoistwaykey;

    // Use this for initialization
    void Start()
    {
       
    }

    void OnTriggerEnter(Collider other)
    {
         Hoistwaykey = ItemGet.Hoistwaykey;

        if (other.gameObject.CompareTag("Player"))
        {

            
           

            if (count == true)
            {
                GameObject Door = GameObject.Find("genkan door (1)").gameObject;
                Quaternion q = Quaternion.Euler(0f,-2f,0f);
                Door.transform.rotation = q;
                Vector3 v = Door.transform.localPosition;
                v.z += 1.7f;
                Door.transform.localPosition = v;
                count = false;
            }

           

            if (Hoistwaykey == 1 && count == false)
            {
                GameObject Door = GameObject.Find("genkan door (1)").gameObject;
                Quaternion q = Quaternion.Euler(0f, 100f, 0f);
                Door.transform.rotation = q;
                Vector3 v = Door.transform.localPosition;
                v.z -= 1.7f;
                Door.transform.localPosition = v;
                count = true;
            }
        }

       
    }

    // Update is called once per frame
    void Update()
    {

    }
}

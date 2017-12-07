using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door3 : MonoBehaviour
{
    public static bool count3 = true;

    // Use this for initialization
    void Start()
    {

    }

    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Player"))
        {

            if (count3 == true)
            {
                GameObject Door = GameObject.Find("E3Door").gameObject;
                Vector3 v = Door.transform.localPosition;
                v.x -= 5;
                Door.transform.localPosition = v;
                count3 = false;
            }


        }

    }


    /*void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if 
            {

            }

        }
    }*/

    // Update is called once per frame
    void Update()
    {

    }
}

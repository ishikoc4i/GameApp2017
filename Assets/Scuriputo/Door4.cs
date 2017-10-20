using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door4 : MonoBehaviour
{
    public static bool count4 = true;

    // Use this for initialization
    void Start()
    {

    }

    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Player"))
        {

            if (count4 == true)
            {
                GameObject Door = GameObject.Find("E1Door").gameObject;
                Vector3 v = Door.transform.localPosition;
                v.x -= 5;
                Door.transform.localPosition = v;
                count4 = false;
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

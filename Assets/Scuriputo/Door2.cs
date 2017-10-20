using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door2 : MonoBehaviour
{
    public static bool count2 = true;

    // Use this for initialization
    void Start()
    {

    }

    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Player"))
        {

            if (count2 == true)
            {
                GameObject Door = GameObject.Find("Chemical RoomDoor").gameObject;
                Vector3 v = Door.transform.localPosition;
                v.z += 5;
                Door.transform.localPosition = v;
                count2 = false;
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

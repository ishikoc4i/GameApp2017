using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public static bool count = true;

    // Use this for initialization
    void Start()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Player"))
        {

            if(count == true)
            {
                GameObject Door = GameObject.Find(" Physical roomDoor").gameObject;
                Vector3 v = Door.transform.localPosition;
                v.z += 5;
                Door.transform.localPosition = v;
                count = false;
            }
            

        }

        /*if (count == false)
        {

            GameObject Door = GameObject.Find(" Physical roomDoor").gameObject;
            Vector3 v = Door.transform.localPosition;
            v.z -= 5;
            Door.transform.localPosition = v;
            count = true;
        }*/
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
        
        //countTime += Time.deltaTime;
        //Debug.Log(countTime.ToString("F2"));
    }
}

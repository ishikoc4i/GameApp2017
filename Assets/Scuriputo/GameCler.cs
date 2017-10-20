using UnityEngine;
using UnityEngine.SceneManagement;

//public ItemGet ItemGet;


public class GameCler : MonoBehaviour
{
    


    public void OnTriggerEnter(Collider other)
       {

            if (other.gameObject.CompareTag("Player"))
            {
               

            if (ItemGet.Hoistwaykey == 1)
                {
                    SceneManager.LoadScene("clear");
                    Debug.Log("Gamecler");

                }
            }

       }
       
           
    
}
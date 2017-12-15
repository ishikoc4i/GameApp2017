using UnityEngine;
using UnityEngine.SceneManagement;

//public ItemGet ItemGet;


public class GameCler : MonoBehaviour
{

    public int Hoistwaykey;

    public void OnTriggerEnter(Collider other)
    {

        Hoistwaykey = ItemGet.Hoistwaykey;
            if (other.gameObject.CompareTag("Player"))
            {
               

            if (Hoistwaykey == 1)
                {
                    SceneManager.LoadScene("clear");
                    

                }
            }

    }

    

}
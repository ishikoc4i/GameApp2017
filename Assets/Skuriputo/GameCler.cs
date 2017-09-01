using UnityEngine;
using UnityEngine.SceneManagement;

//public ItemGet ItemGet;


public class GameCler : MonoBehaviour
{
    /*int puragu;
    int dennkyuu;
    int Key;
    int kouguBako;*/
    private bool puragu = ItemGet.puragu;
    private bool dennkyuu = ItemGet.dennkyuu;
    private bool Key = ItemGet.Key;
    private bool kouguBako = ItemGet.kouguBako;
    public GameObject light;



    public void OnTriggerEnter(Collider other)
       {

            if (other.gameObject.CompareTag("Player"))
            {
                Debug.Log("collision");
                Debug.Log(ItemGet.puragu);
                Debug.Log(dennkyuu);
                Debug.Log(Key);
                Debug.Log(kouguBako);

            if (ItemGet.puragu == true && ItemGet.dennkyuu == true && ItemGet.Key == true && ItemGet.kouguBako == true)
                {
                    SceneManager.LoadScene("clear");
                    Debug.Log("Gamecler");

                }
            }

       }
       
           
    
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class CoinPicker : MonoBehaviour
{


    public float coin = 0;
   
  

    public TextMeshProUGUI textCoins;


    private void OnTriggerEnter(Collider other)
    {
     
        
        if (other.transform.tag == "Trash")
        {
            Debug.Log("Collision Completed");
            Debug.Log("Detected tag");
            coin++;
            textCoins.text = coin.ToString();
            Destroy(other.gameObject);
            Debug.Log("Trash destroyed");
            //SceneManager.LoadScene(ARscene:"ARScene");
    


        }
 
        
    }
}

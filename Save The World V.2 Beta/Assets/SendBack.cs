using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SendBack : MonoBehaviour
{

    public float coin = 0;


    void OnTriggerEnter(Collider other)
    {
        coin++;
        SceneManager.LoadScene("TrashGame");
  
    }
}

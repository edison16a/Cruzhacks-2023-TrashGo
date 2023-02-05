using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SendBack : MonoBehaviour
{
    void Start()
    {
        textCoins.text = coin.ToString() + "\n " + variableHolder.points;
    }

    void OnTriggerEnter(Collider other)
    {
        variableHolder.points++;
    }
}

/*if (variableHolder.trash <= 0)
        {
            SceneManager.LoadScene("TrashGame");
        }*/
//SceneManager.LoadScene("TrashGame");
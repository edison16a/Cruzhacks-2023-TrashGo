using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SendBack : MonoBehaviour
{

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
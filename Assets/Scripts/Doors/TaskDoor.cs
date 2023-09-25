using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TaskDoor : MonoBehaviour
{
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("winscreen");
        }
    }
}

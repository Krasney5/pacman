using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace ScriptsPoint
{


    public class key : MonoBehaviour
    {
        private keyControler score;


        private void Awake()
        {
            score = FindObjectOfType<keyControler>();
        }

        private void OnTriggerEnter(Collider collider)
        {
            if (collider.gameObject.tag == "Player")
            {
                Destroy(gameObject);
                score.addScore();

            }
        }
    }
}
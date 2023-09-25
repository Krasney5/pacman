using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace ScriptsPoint
{


    public class key : MonoBehaviour
    {
        private keyControler _controler;


        private void Awake()
        {
            _controler = FindObjectOfType<keyControler>();
        }

        private void OnTriggerEnter(Collider collider)
        {
            if (collider.gameObject.tag == "Player")
            {
                Destroy(gameObject);
                _controler.addScore();
                _controler.SpawnDoor();
            }
        }
    }
}
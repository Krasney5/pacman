using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


namespace ScriptsPoint
{


    public class keyControler : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _scoreText;
        [SerializeField] private int _score;

        private void Start()
        {
            _scoreText.text = _score.ToString();
        }

        public void addScore()
        {
            _score++;
            _scoreText.text = _score.ToString();
            print("бубл");
        }
    }
}
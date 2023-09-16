using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class keyControler : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _scoreText;
    [SerializeField] private int _score;

    protected void addScore()
    {
        _score++;
        _scoreText = ToString(_score);
    }
}

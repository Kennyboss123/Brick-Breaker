using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    GameManager gameManager;
    [SerializeField] TMP_Text scoreText;
    // Start is called before the first frame update
    void Update()
    {
        UpdateScore();
    }
    private void UpdateScore()
    {
        scoreText.text = GameManager.Instance.GetScore().ToString();
    }
}

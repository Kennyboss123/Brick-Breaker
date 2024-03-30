using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    [SerializeField] Button playAgain;
    private void Start()
    {
        RegisterButtons();
    }

    private void RegisterButtons()
    {
        playAgain.onClick.AddListener(RestartGame);
    }

    public void RestartGame()
    {
        GameManager.Instance.ResetGame();
    }
}

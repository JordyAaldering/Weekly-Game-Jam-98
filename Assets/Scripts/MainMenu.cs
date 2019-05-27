﻿using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI highScoreText = null;

    private void Start()
    {
        int highScore = PlayerPrefs.GetInt("highScore");
        if (highScore > 0)
        {
            highScoreText.text = "HIGH SCORE: " + highScore;
            highScoreText.enabled = true;
        }
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}

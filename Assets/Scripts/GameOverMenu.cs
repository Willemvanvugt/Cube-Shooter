using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : HomeMenu
{
    public TextMeshProUGUI playerScore;

    private void Start()
    {
        DisplayScore();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(0);
        Debug.Log("Game was restarted.");
    }

    private void DisplayScore()
    {
        playerScore.text = GameManager.scoreString;
        Debug.Log("Final game score is " + playerScore.text);
    }
}

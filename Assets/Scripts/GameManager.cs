using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI playerName;
    public int score;
    public TextMeshProUGUI scoreText;
    public static string scoreString;

    private void Start()
    {
        playerName.text = HomeMenu.playerNameInput;
        UpdateScore(0);
        score = 0;
    }

    public void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "Score: " + score;
        scoreString = scoreText.text;
    }
}

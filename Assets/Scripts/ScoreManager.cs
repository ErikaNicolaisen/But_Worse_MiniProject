using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highScoreText;
    public int score = 0;
    public int highscore = 0;
    public static ScoreManager instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            LoadHighScore();
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void AddScore(int value)
    {
            score += value;
            scoreText.text = "Score: " + score.ToString();

        if (score > highscore)
        {
            highscore = score;
            highScoreText.text = "Highscore: " + highscore.ToString();
            SaveHighScore();
        }
    }

    public void ResetScore()
    {
        score = 0;
        scoreText.text = "Score: " + score.ToString();
    }

    private void LoadHighScore()
    {
        highscore = PlayerPrefs.GetInt("HighScore", 0);

        if (highScoreText != null)
        {
            highScoreText.text = "Highscore: " + highscore.ToString();
        }
    }


    private void SaveHighScore()
    {
        PlayerPrefs.SetInt("HighScore", highscore);
        PlayerPrefs.Save();
    }
}
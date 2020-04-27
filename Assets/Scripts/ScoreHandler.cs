using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class ScoreHandler : MonoBehaviour
{
    public Image ScoreIcon;
    public Text ScoreText;
    int score = 0;
    int highScore = 0;

    public void Start()
    {
        GetLastHighScore();
    }
    public void UpdateScore()
    {
        score++;
        ScoreText.text = score.ToString();
        ScoreIcon.color = Color.white;
        
        if(score > highScore)
        {
            SaveScore(score);
        }
    }
    public void UpdateColor()
    {
        ScoreIcon.color = Color.red;
    }

    public void UpdateColor(ColorProperties[] availableColors, string _UpdateColor)
    {
        for (int i = 0; i < availableColors.Length; i++)
        {
            if (availableColors[i].Name == _UpdateColor)
            {
                ScoreIcon.color = availableColors[i].color;
            }
        }
    }

    public void GetLastHighScore()
    {
        highScore = PlayerPrefs.GetInt("HighScore");
    }
    public void SaveScore(int _score)
    {
        ScoreIcon.color = Color.green;
        PlayerPrefs.SetInt("HighScore", _score);
    }
 
}

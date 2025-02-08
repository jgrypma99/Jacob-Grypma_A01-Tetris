using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;

public class Timer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    public float timeRemaining = 30f;
    [SerializeField] TextMeshProUGUI scoreText;
    public Tetromino Tetromino;
    [SerializeField] TextMeshProUGUI gameOver;

    void Awake()
    {
        gameOver.gameObject.SetActive(false);    
    }

    // Update is called once per frame
    void Update()
    {
        Tetromino = FindObjectOfType<Tetromino>();
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
        }
        timerText.text = timeRemaining.ToString();
        //update score text
        scoreText.text = Tetromino.score.ToString();
        if (timeRemaining <= 0)
        {
            timeRemaining = 0;
            gameOver.gameObject.SetActive(true);
        }
    }
}

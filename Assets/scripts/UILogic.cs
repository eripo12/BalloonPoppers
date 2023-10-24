using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UILogic : MonoBehaviour
{

    public float playerScore = 0;
    public Text scoreText;

    public float gameTime = 0.1f;
    public Text timerText;

    public float scorePerTime = 1.0f;
    public Text scorePerTimeText;

    public float scoreMultiplier; 

 

    public void addScore()
    {
        scoreMultiplier = gameTime / 10 + 1;
        playerScore = playerScore + (1 * scoreMultiplier);
        scoreText.text = playerScore.ToString("#");
    }

    public void subtractScore()
    {
        if (playerScore > 0)
        {
            playerScore = playerScore - (1 * scoreMultiplier);
            scoreText.text = playerScore.ToString("#");
        }
        if (playerScore < 0)
        {
            playerScore = 0;
            scoreText.text = playerScore.ToString("#");
        }
        
    }

    void Update()
    {
        gameTime += Time.deltaTime;
        scorePerTime = playerScore / gameTime;


        timerText.text = gameTime.ToString("#.##");
        scorePerTimeText.text = scorePerTime.ToString("#.##");
    }

    public float getScore()
    {
        return playerScore;
    }

    public float getScorePerSec() {
        return scorePerTime;
    }

    

    
}

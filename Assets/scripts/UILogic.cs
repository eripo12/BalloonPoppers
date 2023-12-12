using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UILogic : MonoBehaviour
{

    public float playerScore = 0;
    public Text scoreText;

    public float gameTime = 0.1f;
    public Text timerText;

    public float scorePerTime = 1.0f;
    public Text scorePerTimeText;

    public float scoreMultiplier;
    private int difficultyMultiplier = 1;

    public float missesLeft = 10;
    public Text missesLeftText;

    static float finalScore;

    public void addScore()
    {
        if (SceneManager.GetActiveScene().buildIndex == 2)
            difficultyMultiplier = 2;
        else if (SceneManager.GetActiveScene().buildIndex == 3)
            difficultyMultiplier = 4;
        scoreMultiplier = gameTime / 10 + 1;
        playerScore = playerScore + (1 * scoreMultiplier * difficultyMultiplier);
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

    public void Start()
    {
        
    }

    public void subtractMissesLeft()
    {
        missesLeft = missesLeft - 1;
        missesLeftText.text = missesLeft.ToString("#");
    }

    public void gameOver()
    {
        if (missesLeft == 0)
        {
            finalScore = getScore();
            Debug.Log(playerScore);
            finalScore = playerScore;
            Debug.Log(finalScore);

            SceneManager.LoadScene(5);
            missesLeft = 10;
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
        return finalScore;
    }

    public float getScorePerSec() {
        return scorePerTime;
    }

    public void addBalloons()
    {
        missesLeft++;
        missesLeftText.text = missesLeft.ToString("#");
    }

    

    
}

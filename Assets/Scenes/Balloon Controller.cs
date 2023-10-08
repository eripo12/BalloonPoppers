using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement; 

public class BalloonController : MonoBehaviour
{
    public float upSpeed;
    int score = 0;

    public TextMeshProUGUI scoreText; 
   
    // Update is called once per frame
    void Update()
    {
        if(transform.position.y > 400f)
        {
            ResetPosition();
        }
    }

    private void FixedUpdate()
    {
        transform.Translate(0, upSpeed, 0); 
    }


    private void OnMouseDown()
    {
        score++;
        scoreText.text = score.ToString(); 

        ResetPosition();
    }

    private void ResetPosition()
    {
        float randomX = Random.Range(-200f, 200f);

        transform.position = new Vector2(randomX, -400f); 

    }
}

using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement; 

public class BalloonController : MonoBehaviour
{
    public UILogic logic;
    public float upSpeed;
    public float upSpeedMultiplier = 1;
    public int ballonWave = 0;
    private float gameTime = .01f;



   void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<UILogic>();
    }

    // Update is called once per frame
    void Update()
    {
        gameTime += Time.deltaTime;
        if(transform.position.y > 400f)
        {
            logic.subtractScore();
            ResetPosition();
            upSpeedMultiplier -= .1f;
        }
    }

    private void FixedUpdate()
    {
        if (ballonWave == 1)
        {
            transform.Translate(0, upSpeed * upSpeedMultiplier, 0);
        }

        if (ballonWave == 2 && gameTime > 10.0)
        {
            transform.Translate(0, (upSpeed + 1) * upSpeedMultiplier, 0);
        }

        if (ballonWave == 3 && gameTime > 40.0)
        {
            transform.Translate(0, (upSpeed+2) * upSpeedMultiplier, 0);
        }

        if (ballonWave == 4 && gameTime > 30.0)
        {
            transform.Translate(0, (upSpeed + 2) * upSpeedMultiplier, 0);
        }

    }
        
    private void OnMouseDown()
    {
        logic.addScore();
        upSpeedMultiplier += .1f;
        ResetPosition();

    }

    private void ResetPosition()
    {
        float randomX = Random.Range(-200f, 200f);

        transform.position = new Vector2(randomX, -450f); 

    }
}

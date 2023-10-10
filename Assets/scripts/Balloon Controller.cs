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



   void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<UILogic>();
    }

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
        transform.Translate(0, upSpeed * upSpeedMultiplier, 0); 
    }


    private void OnMouseDown()
    {
        logic.addScore();
        ResetPosition();

    }

    private void ResetPosition()
    {
        float randomX = Random.Range(-200f, 200f);

        transform.position = new Vector2(randomX, -450f); 

    }
}

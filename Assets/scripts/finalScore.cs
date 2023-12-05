using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class finalScore : MonoBehaviour
{
    public UILogic logic;
    public Text finalScoreText;
    private float score = 0;


    // Start is called before the first frame update
    void Start()
    {

        Debug.Log("Hello");
        endScore();

    }

    // Update is called once per frame
    void endScore()
    {
        score = logic.getScore();
        finalScoreText.text = score.ToString("#");
    }
}

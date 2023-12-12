using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class finalScore : MonoBehaviour
{
    public UILogic logic;
    public Text finalScoreText;
    private float Escore = 0;
    private int intScore;
    public ScoreManager sm;


    // Start is called before the first frame update
    void Start()
    {

        Debug.Log("Hello");
        endScore();

    }

    // Update is called once per frame
    void endScore()
    {
        Escore = logic.getScore();
        intScore = Mathf.RoundToInt(Escore);
        sm.AddScore(new Score("Eric", intScore));
        finalScoreText.text = Escore.ToString("#");
    }
}

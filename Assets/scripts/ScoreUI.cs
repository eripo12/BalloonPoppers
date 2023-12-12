// ScoreUI.cs
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class ScoreUI : MonoBehaviour
{
    public RowUI rowUI;
    public UILogic logic;

    public ScoreManager scoreManager;

    void Start()
    {
       
        

        var scores = scoreManager.GetHighScores().ToArray();

        for (int i = 0; i < scores.Length; i++)
        {
            var row = Instantiate(rowUI, transform).GetComponent<RowUI>();
            row.rank.text = (i + 1).ToString();
            row.playerName.text = scores[i].name;
            row.score.text = scores[i].score.ToString();
        }
    }
}
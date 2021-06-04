using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    // Score Manager ................................IT15099600
    public static ScoreManager instance;
    public TextMeshProUGUI text;
    int score;
    public TextMeshProUGUI text2;
    int score2;
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ChangeScore(int coinValue)
    {
        score += coinValue;
        text.text = "X" + score.ToString();
    }



    public void ChangeScore2(int gemValue)
    {
        score2 += gemValue;
        text2.text = "X" + score2.ToString();
    }
}

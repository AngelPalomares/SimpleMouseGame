using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreLogic : MonoBehaviour
{
    public static ScoreLogic instance;
    public Text txt;

    public Text Maxxcore;

    int MaxScore;
    int LastScore;
    public int Score = 0;

    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        MaxScore = PlayerPrefs.GetInt("Score", Score);

        Maxxcore.text = "Max Score: " + MaxScore;
    }

    // Update is called once per frame
    void Update()
    {
        PrintScore();
    }

    public void AddtoScore()
    {
        Score = Score + 1;
        PrintScore();

        if(Score > MaxScore)
        {
           PlayerPrefs.SetInt("Score", Score);
        }
    }

    public void PrintScore()
    {
        txt.text = "Score: " + Score;

    }
}

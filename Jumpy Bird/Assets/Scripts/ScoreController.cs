using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    public static ScoreController instance;

    public Text Score;

    int score;

    void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        Score.text = score.ToString();
    }

    public void AddPoint()
    {
        score++;
        Score.text = score.ToString();
    }
}

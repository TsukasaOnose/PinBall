using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    private Text scoreText;
    private int oldScore;

    // Start is called before the first frame update
    void Start()
    {
        scoreText = GetComponent<Text>();
        if (scoreText != null && GManager.instance != null)
        {
            scoreText.text = GManager.instance.score.ToString();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (scoreText != null && GManager.instance != null)
        {
            if (oldScore != GManager.instance.score)
            {
                scoreText.text = GManager.instance.score.ToString();
                oldScore = GManager.instance.score;
            }
        }
    }
}

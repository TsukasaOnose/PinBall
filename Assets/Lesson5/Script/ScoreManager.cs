using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    //スコアの初期値
    private int score = 0;
    private GameObject scoreText;

    // Start is called before the first frame update
    void Start()
    {
        this.scoreText = GameObject.Find("ScoreText");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //スコアに加算していく関数を作成
    public void AddScore(int additionValue)
    {
        //「amount」に入ってくる数値分加算していく
        score += additionValue;
        //スコアのテキストを上書きする
        this.gameObject.GetComponent<Text>().text = "Score " + score;
    }
}

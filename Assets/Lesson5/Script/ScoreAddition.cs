using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ScoreAddition : MonoBehaviour
{
    //ScoreManagerのスクリプトの変数
    private ScoreManager sm;
    //各ターゲット毎の点数
    public int smallstarpoints = 10;
    public int largestarpoints = 50;
    public int smallcloudpoints = 30;
    public int largecloudpoints = 80;

    private void Start()
    {
        //ScoreTextにコンポーネントされたScoreManagerのスクリプトを取得
        sm = GameObject.Find("ScoreText").GetComponent<ScoreManager>();
    }

    private void Update()
    {

    }

    //ターゲット接触時の動作動作の関数。タグ毎に、Add関数へ渡す引数を設定
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("SmallStarTag"))
        {
            sm.AddScore(smallstarpoints);
        }
        else if (other.gameObject.CompareTag("LargeStarTag"))
        {
            sm.AddScore(largestarpoints);
        }
        else if (other.gameObject.CompareTag("SmallCloudTag"))
        {
            sm.AddScore(smallcloudpoints);
        }
        else if (other.gameObject.CompareTag("LargeCloudTag"))
        {
            sm.AddScore(largecloudpoints);
        }
    }
}

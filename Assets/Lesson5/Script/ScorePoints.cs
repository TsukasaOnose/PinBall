using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ScorePoints : MonoBehaviour
{
    public int myScore;
    //SmallStarの点数
    public int smallstarPoints = 10;
    //LargeStarの点数
    public int largestarPoints = 50;
    //SmallCloudの点数
    public int smallcloudPoints = 20;
    //LargeCloudの点数
    public int largecloudpoints = 80;

    private void Start()
    {
        //SmallStarに当たった時
        if (tag == "SmallStarTag")
        {
            if (GManager.instance != null)
            {
                GManager.instance.score += smallstarPoints;
            }
        }
        //LargeStarに当たった時
        if (tag == "LargeStarTag")
        {
            if (GManager.instance != null)
            {
                GManager.instance.score += largestarPoints;
            }
        }
        //SmallCloudに当たった時
        if (tag == "SmallCloud")
        {
            if (GManager.instance != null)
            {
                GManager.instance.score += smallcloudPoints;
            }
        }
        //LargeColudに当たった時
        if (tag == "LargeCloud")
        {
            if (GManager.instance != null)
            {
                GManager.instance.score += largecloudpoints;
            }
        }
    }

    private void Update()
    {
       
    }

    //衝突時に呼ばれる関数
    void OnCollisionEnter(Collision collision)
    {
        
    }
}

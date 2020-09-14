using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchController : MonoBehaviour
{
    //HingeJointコンポーネントを入れる
    private HingeJoint myHingeJoint;
    //初期の傾き
    private float defaultAngle = 20;
    //弾いた時の傾き
    private float flickAngle = -20;
    //タッチID
    int? touchId = null;

    // Start is called before the first frame update
    void Start()
    {
        //HingeJointコンポーネント取得
        this.myHingeJoint = GetComponent<HingeJoint>();

        //フリッパーの傾きを設定
        SetAngle(this.defaultAngle);
        
    }

    // Update is called once per frame
    void Update()
    {
        ///<sammary>
        ///タッでの操作
        /// </sammary>
        
        //触れている指の数を取得
        int touchCount = Input.touchCount;

        //forループを、タッチしてる数だけ行う
        for (int i = 0; i < touchCount; i++)
        {
            //画面に触れている部分の情報が入ったインスタンスを取得
            Touch touch = Input.GetTouch(i);
            {
                //画面左側をタップした時、タッチIDを割り振り、左フリッパーを動かす
                if (touch.phase == TouchPhase.Began && touch.position.x <= Screen.width / 2 && tag == "LeftFripperTag")
                {
                    touchId = Input.touches[i].fingerId;
                    SetAngle(flickAngle);
                }

                //画面右側をタップした時、タッチIDを割り振り、右フリッパーを動かす
                if (touch.phase == TouchPhase.Began && touch.position.x >= Screen.width / 2 && tag == "RightFripperTag")
                {
                    touchId = Input.touches[i].fingerId;
                    SetAngle(flickAngle);
                }

                //画面から指を離した時、割り振られたIDのフリッパーを元の位置に動かす
                if (Input.touches[i].fingerId == touchId && touch.phase == TouchPhase.Ended && tag == "LeftFripperTag")
                {
                    SetAngle(defaultAngle);
                    touchId = null;
                }
                if (Input.touches[i].fingerId == touchId && touch.phase == TouchPhase.Ended && tag == "RightFripperTag")
                {
                    SetAngle(defaultAngle);
                    touchId = null;
                }
            }
        }
    }


    //フリッパーの傾きを設定
    public void SetAngle(float angle)
    {
        JointSpring jointSpr = this.myHingeJoint.spring;
        jointSpr.targetPosition = angle;
        this.myHingeJoint.spring = jointSpr;
    }
}

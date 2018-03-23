using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// 总控脚本
/// </summary>
public class Gamemanager : MonoBehaviour
{
    public Transform player1;
    public Transform player2;


    // Use this for initialization
    void Start()
    {
        ResetPlayer();
    }


    // Update is called once per frame
    void Update()
    {
    }


    /// <summary>
    /// 重置玩家位置
    /// </summary>
    void ResetPlayer()
    {
        Vector3 temVector3 = Camera.main.ScreenToWorldPoint(new Vector2(100, Screen.height / 2));
        temVector3.z       = 0;
        player1.position   = temVector3;
        temVector3         = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width - 100, Screen.height / 2));
        temVector3.z       = 0;
        player2.position   = temVector3;
    }


    public void ButtonClick()
    {
        GameObject.Find("Ball").SendMessage("Reset");
    }
}
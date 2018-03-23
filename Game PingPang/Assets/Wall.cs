using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Wall : MonoBehaviour
{
    private BoxCollider2D wallCollider2D;
    private BoxCollider2D wallCollider2D1;
    private BoxCollider2D wallCollider2D2;
    private BoxCollider2D wallCollider2D3;


    void Start()
    {
        ResetWall();
    }


    // Update is called once per frame
    void Update()
    {
    }


    /// <summary>
    /// 重置墙壁
    /// </summary>
    private void ResetWall()
    {
        wallCollider2D  = transform.Find("Wall").GetComponent<BoxCollider2D>();
        wallCollider2D1 = transform.Find("Wall (1)").GetComponent<BoxCollider2D>();
        wallCollider2D2 = transform.Find("Wall (2)").GetComponent<BoxCollider2D>();
        wallCollider2D3 = transform.Find("Wall (3)").GetComponent<BoxCollider2D>();

        //2D游戏中，动态修改碰撞盒的长度大小
        Vector3 temVector3 = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height)); //屏幕右上角的点转世界坐标
        //上
        wallCollider2D.transform.position = new Vector3(0, temVector3.y + 0.5f, 0);
        wallCollider2D.size               = new Vector2(temVector3.x * 2, 1);
        //下
        wallCollider2D1.transform.position = new Vector3(0, -temVector3.y - 0.5f, 0);
        wallCollider2D1.size               = new Vector2(temVector3.x * 2, 1);
        //左
        wallCollider2D2.transform.position = new Vector3(-temVector3.x - 0.5f, 0, 0);
        wallCollider2D2.size               = new Vector2(1, temVector3.y * 2);
        //右
        wallCollider2D3.transform.position = new Vector3(temVector3.x + 0.5f, 0, 0);
        wallCollider2D3.size               = new Vector2(1, temVector3.y * 2);
    }
}
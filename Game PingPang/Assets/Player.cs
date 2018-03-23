using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// 玩家脚本
/// </summary>
public class Player : MonoBehaviour
{
    public  KeyCode     UpKeyCode;   //上按键
    public  KeyCode     DownKeyCode; //下按键
    private Rigidbody2D rigidbody2;
    public  float       speed = 10; //速度
    private AudioSource audioSource;//声音

    void Start()
    {
        rigidbody2 = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
    }


    void Update()
    {
        if (Input.GetKey(UpKeyCode))
        {
            rigidbody2.velocity = new Vector2(0, speed);
        }
        else if (Input.GetKey(DownKeyCode))
        {
            rigidbody2.velocity = new Vector2(0, -speed);
        }
        else
        {
            rigidbody2.velocity = new Vector2(0, 0);
        }
    }


    private void OnCollisionEnter2D()
    {
        audioSource.pitch = Random.Range(0.6f, 1);
        audioSource.Play();
    }
}
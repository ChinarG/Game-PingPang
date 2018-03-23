using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Ball : MonoBehaviour
{
    private Rigidbody2D rg; //自身刚体


    void Start()
    {
        rg      = GetComponent<Rigidbody2D>();
        int num = Random.Range(0, 2);
        if (num == 1)
        {
            rg.AddForce(new Vector2(100, 0));
        }
        else
        {
            rg.AddForce(new Vector2(-100, 0));
        }
    }


    /// <summary>
    /// 碰撞触发
    /// </summary>
    /// <param name="collision"></param>
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Player")
        {
            Vector2 velocity = rg.velocity;
            velocity.y       = velocity.y / 2 + collision.rigidbody.velocity.y;
            rg.velocity      = velocity;

            if (velocity.x < 9 && velocity.x > -9 && velocity.x != 0)
            {
                if (velocity.x>0)
                {
                    velocity.x = 10;
                }
                else
                {
                    velocity.x = -10;
                }
                rg.velocity = velocity;
            }
        }
    }


    private void Reset()
    {
        print("充值");
        transform.position = Vector3.zero;
  
    }


}
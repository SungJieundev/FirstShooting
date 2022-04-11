using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : BulletMove
{
    //public 접근 가능
    //private 상속이어도 x
    //protected 상속받은 class의 변수를 가져올 수 있다 

    //충돌이 일어나려면 
    //둘중 하나가 RigidBody2D 가 있어야 하고,
    //둘 다 BoxCollider2D 가 있어야함

    private float a = 0;

    protected override void Start()
    {
        speed = 2;
    }



    //IsTrigger 가 켜진 상태로 들어갔을 때
    protected override void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Bullet")) //enemy 가 Bullet과 3번 충돌하면 Destroy
        {
            Destroy(other.gameObject);
            a++;
            if (a >= 2)
            {
                Destroy(gameObject);
                a = 0;
                ScoreManager.Instance.Plusscore();
            }
        }
    }


}


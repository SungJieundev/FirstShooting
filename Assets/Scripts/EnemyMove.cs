using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : BulletMove
{
    //public ���� ����
    //private ����̾ x
    //protected ��ӹ��� class�� ������ ������ �� �ִ� 

    //�浹�� �Ͼ���� 
    //���� �ϳ��� RigidBody2D �� �־�� �ϰ�,
    //�� �� BoxCollider2D �� �־����

    private float a = 0;

    protected override void Start()
    {
        speed = 2;
    }



    //IsTrigger �� ���� ���·� ���� ��
    protected override void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Bullet")) //enemy �� Bullet�� 3�� �浹�ϸ� Destroy
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


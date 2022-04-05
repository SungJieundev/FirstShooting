using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{
    public float speed = 20f;

    protected virtual void Start() //virtual, �������� �Լ��� ����� �� override, ������ 
    {
        speed = 10f;
    }

    void Update()
    {
        BMove();
    }

    private void BMove()
    {
        transform.Translate(Vector2.up * speed * Time.deltaTime);
    }

    protected virtual void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.CompareTag("Wall"))
        //if (collision.CompareTag("Bullet"))
        {
            Destroy(gameObject);
        }
    }
}

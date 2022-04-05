using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour
{
    public Image hpGage = null;
    public float speed = 10f;
    private Rigidbody2D rb = null;
    public GameObject bullet = null;
    public float shootDuration = 2f;
    


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        StartCoroutine(Shooting());
    }


    void Update()
    {
        RbMove();
    }

    private void RbMove() //�浹�� �ִ� ��� ���� �� ����
    {
        //���α��� ���� : -1  �ȴ����� : 0  ������ :1
        float hori = Input.GetAxisRaw("Horizontal");
        //���α��� �� : 1 �ȴ����� : 0 �� : -1
        float verti = Input.GetAxisRaw("Vertical");

        rb.velocity = new Vector2(hori, verti).normalized * speed;
    }

    private IEnumerator Shooting() //�ڷ�ƾ, �Ѿ� �߻� �ڵ�
    {
        while (true)
        {
            yield return new WaitForSeconds(shootDuration);
            Instantiate(bullet, transform.position, Quaternion.identity);
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy")) //player �� Enemy�� �浹�ϸ� DecreaseHp
        {
            hpGage.fillAmount -= 0.2f;
            if (hpGage.fillAmount <= 0)
            {
                Destroy(gameObject);
                SceneManager.LoadScene("gameover");
            }
        }
    }
}
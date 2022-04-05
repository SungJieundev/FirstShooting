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

    private void RbMove() //충돌이 있는 경우 쓰는 게 좋음
    {
        //가로기준 왼쪽 : -1  안누르면 : 0  오른쪽 :1
        float hori = Input.GetAxisRaw("Horizontal");
        //세로기준 위 : 1 안누르면 : 0 밑 : -1
        float verti = Input.GetAxisRaw("Vertical");

        rb.velocity = new Vector2(hori, verti).normalized * speed;
    }

    private IEnumerator Shooting() //코루틴, 총알 발사 코드
    {
        while (true)
        {
            yield return new WaitForSeconds(shootDuration);
            Instantiate(bullet, transform.position, Quaternion.identity);
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy")) //player 가 Enemy와 충돌하면 DecreaseHp
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
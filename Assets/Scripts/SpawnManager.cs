using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    private Rigidbody2D rb;

    public GameObject enemy = null;
    public GameObject boss = null;

    public Vector2 spawnPos = Vector2.zero;
    public float enemyDuration = 3f;

    public Transform maxPos = null;
    public Transform minPos = null;

    void Start()
    {
        StartMethod();
    }

    
    void Update()
    {
        BossSpawn();
    }

    IEnumerator coroutine;

    void StartMethod()
    {
        coroutine = SpawnEnemy();
        StartCoroutine(coroutine);
    }
    void StopMethod()
    {
        coroutine = SpawnEnemy();
        StopCoroutine(coroutine);
    }



    private IEnumerator SpawnEnemy()
    {
        while (true)
        {

            Instantiate(enemy, new Vector2(Random.Range(minPos.position.x, maxPos.position.x), maxPos.position.y), enemy.transform.rotation);
            yield return new WaitForSeconds(enemyDuration);
        }
    }

    

    void BossSpawn()
    {
        if(ScoreManager.Instance.score == 15)
        {
            Instantiate(boss, transform.position, Quaternion.identity);
            StartMethod();
            ScoreManager.Instance.score++;
        }
    }
}

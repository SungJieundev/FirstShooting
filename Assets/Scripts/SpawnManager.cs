using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    private Rigidbody2D rb;

    public GameObject enemy = null;

    public Vector2 spawnPos = Vector2.zero;
    public float enemyDuration = 3f;

    public Transform maxPos = null;
    public Transform minPos = null;

    void Start()
    {
        StartCoroutine(SpawnEnemy());
    }

    
    void Update()
    {
        
    }

    private IEnumerator SpawnEnemy()
    {
        while (true)
        {

            Instantiate(enemy, new Vector2(Random.Range(minPos.position.x, maxPos.position.x), maxPos.position.y), enemy.transform.rotation);
            yield return new WaitForSeconds(enemyDuration);
        }
    }
}

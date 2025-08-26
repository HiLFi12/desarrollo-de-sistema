using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
public EnemyFactory enemyFactory;
    public float spawnInterval = 3f;
    public Transform[] spawnPoints;

    private float timer;

    private void Update()
    {
        timer += Time.deltaTime;
        if (timer >= spawnInterval)
        {
            timer = 0f;
            SpawnEnemy();
        }
    }

    void SpawnEnemy()
    {
        if (spawnPoints.Length > 0 || enemyFactory == null)
        {
            return;
        }

        Transform randomPoint = spawnPoints[Random.Range (0, spawnPoints.Length)];
        enemyFactory.CreateEnemy(randomPoint.position, Quaternion.identity);

    }
}

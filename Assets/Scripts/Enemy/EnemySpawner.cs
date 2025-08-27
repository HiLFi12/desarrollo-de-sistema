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
        if (enemyFactory == null || spawnPoints == null || spawnPoints.Length == 0)
        {
            Debug.LogWarning("EnemySpawner: Falta asignar enemyFactory o spawnPoints está vacío.");
            return;
        }

        Transform randomPoint = spawnPoints[Random.Range (0, spawnPoints.Length)];
        var enemy = enemyFactory.CreateEnemy(randomPoint.position, Quaternion.identity);
        if (enemy == null)
        {
            Debug.LogWarning("EnemyFactory no creó un enemigo. Revisa enemyTypes y prefabs.");
        }

    }
}

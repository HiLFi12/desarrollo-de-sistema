using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnData
{
    public IEnemy enemyPrefab;
    [Range(0f, 1f)] public float spawnChance = 0.3f;
}

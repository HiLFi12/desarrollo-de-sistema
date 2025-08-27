using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFactory : MonoBehaviour
{
    public EnemySpawnData[] enemyTypes;

    public IEnemy CreateEnemy(Vector3 position, Quaternion rotation)
    {
        if (enemyTypes == null || enemyTypes.Length == 0)
        {
            Debug.LogWarning(" No hay enemigos configurados");
            return null;
        }
        EnemySpawnData selected = GetRandomEnemyType();
        if(selected == null) return null;

        return Instantiate(selected.enemyPrefab, position, rotation);
    }

    private EnemySpawnData GetRandomEnemyType()
    {
        float rand = Random.value;
        float cumulative = 0f;

        foreach (var type in enemyTypes)
        {
            cumulative += type.spawnChance;
            if (rand <= cumulative)
            {
                return type;
            }
        }
        return enemyTypes[enemyTypes.Length - 1];
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewEnemyData", menuName = "Flyweight/EnemyData", order = 1)]

public class EnemySO : ScriptableObject
{
    public int baseDamage;
    public int maxHealth;
}

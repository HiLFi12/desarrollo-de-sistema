using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class IEnemy : MonoBehaviour
{
    public int health;
    public string enemyName;
    public float speed;
    [SerializeField] private EnemySO enemyData;

    public abstract void Attack();
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class IEnemy : MonoBehaviour
{
    public int health;
    public string enemyName;
    public float speed;

    public abstract void Attack();
}

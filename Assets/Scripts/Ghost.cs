using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost : IEnemy
{
    private void Awake()
    {
        health = 70;
        enemyName = "Ghost";
        speed = 3f;
    }

    public override void Attack()
    {
        Debug.Log($"{enemyName} asusta lentamente");
        throw new System.NotImplementedException();
    }
}

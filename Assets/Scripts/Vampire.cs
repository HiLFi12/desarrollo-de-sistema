using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vampire : IEnemy
{
    private void Awake()
    {
        health = 50;
        enemyName = "Vampire";
        speed = 2.5f;
    }

    public override void Attack()
    {
        Debug.Log($"{enemyName} ataca lentamente");
        throw new System.NotImplementedException();
    }
}


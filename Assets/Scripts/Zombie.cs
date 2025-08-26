using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Zombie : IEnemy
{
  private void Awake()
    {
        health = 100;
        enemyName = "Zombie";
        speed = 2f;
    }

    public override void Attack()
    {
        Debug.Log($"{enemyName} muerde lentamente");
        throw new System.NotImplementedException();
    }
     
}

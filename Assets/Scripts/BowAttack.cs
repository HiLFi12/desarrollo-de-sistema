using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowAttack : IAttackStrategy
{
    public void Attack()
    {
        Debug.Log("Atacando con el arco");
    }
}

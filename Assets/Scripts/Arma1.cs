using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arma1 : Weapon
{
    [SerializeField] private string id;
    public override string Id => id;

    public override void Attack()
    {
        Debug.Log("que");
    }
}

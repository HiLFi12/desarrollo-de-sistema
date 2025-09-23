using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : MonoBehaviour, IAttackStrategy
{
    public abstract string Id { get; }
    public abstract void Attack();
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Shield : MonoBehaviour
{
    public abstract string Id { get; }
    public abstract void Defend();
}

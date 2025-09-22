using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Escudo1 : Shield
{
    [SerializeField] private string id;
    public override string Id => id;

    public override void Defend()
    {
        Debug.Log("ole");
    }
}

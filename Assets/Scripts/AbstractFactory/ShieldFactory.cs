using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldFactory : MonoBehaviour
{
    [SerializeField] private Shield[] shields;

    private Dictionary<string, Shield> shieldDictionary;

    void Start()
    {
       
        shieldDictionary = new Dictionary<string, Shield>();
        foreach (var shield in shields)
        {
            shieldDictionary.Add(shield.Id, shield);
        }
    }

    public Shield CreateShield(string id)
    {
        if (shieldDictionary.ContainsKey(id))
        {
            return Instantiate(shieldDictionary[id]);
        }
        return null;
    }
}

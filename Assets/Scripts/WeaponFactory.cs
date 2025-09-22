using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponFactory : MonoBehaviour
{
    [SerializeField] private Weapon[] weapons;

    private Dictionary<string, Weapon> weaponDictionary;

    void Start()
    {
        weaponDictionary = new Dictionary<string, Weapon>();
        foreach (var weapon in weapons) 
        {
            weaponDictionary.Add(weapon.Id, weapon);
        }
    }
    public Weapon CreateWeapon(string id)
    {
        if (weaponDictionary.ContainsKey(id))
        {
            return Instantiate(weaponDictionary[id]);
        }
        return null;
    }
}

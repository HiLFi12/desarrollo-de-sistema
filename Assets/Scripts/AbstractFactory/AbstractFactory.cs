using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbstractFactory : MonoBehaviour
{
    [SerializeField] private WeaponFactory[] weaponFactory;
    [SerializeField] private ShieldFactory[] shieldFactory;

    void Update()
    {
    if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Weapon weapon = weaponFactory[0].CreateWeapon("sword");
            if (weapon != null)
            {
                Debug.Log("Created weapon: " + weapon.Id);
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Shield shield = shieldFactory[0].CreateShield("shield");
            if (shield != null)
            {
                Debug.Log("Created shield: " + shield.Id);
            }
        }
    }
}

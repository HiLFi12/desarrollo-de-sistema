using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    private IAttackStrategy _currentStrategy;

    public void EquipWeapon(string weaponType)
    {
        switch (weaponType.ToLower())
        {
            case "sword":
                _currentStrategy = new SwordAttack();
                Debug.Log("Espada equipada");
                break;
            case "bow":
                _currentStrategy = new BowAttack();
                Debug.Log("Arco equipado");
                break;
            case "magicwand":
                _currentStrategy = new MagicWand();
                Debug.Log("Varita equipada");
                break;
            default:
                _currentStrategy = null;
                Debug.Log("No se equipo nada");
                break;
        }
    }

    // Nueva sobrecarga: equipar directamente la instancia creada por el factory
    public void EquipWeapon(Weapon weapon)
    {
        if (weapon != null)
        {
            _currentStrategy = weapon;
            Debug.Log("Equipped weapon prefab: " + weapon.Id);
        }
    }

    public void PerformAttack()
    {
        if (_currentStrategy != null)
        {
            _currentStrategy.Attack();
        }
        else
        {
            Debug.Log("No hay nada equipado");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        WeaponPickup pickup = other.GetComponent<WeaponPickup>();
        if (pickup != null)
        {
            EquipWeapon(pickup.weaponType);
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            PerformAttack();
        }
    }
}

using UnityEngine;

public class Zombie : IEnemy
{
  private void Awake()
    {
        health = 100;
        enemyName = "Zombie";
        speed = 2f; // EnemyAI reads this for fallback movement
    }

    public override void Attack()
    {
        Debug.Log($"{enemyName} muerde lentamente");
        // Implementar daño al jugador aquí
    }
     

    private void OnCollisionEnter(UnityEngine.Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Attack();
            Debug.Log("El jugador ha sido atacado por un Zombie");
        }
    }
}

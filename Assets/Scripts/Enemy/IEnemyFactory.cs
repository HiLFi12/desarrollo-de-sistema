using UnityEngine;

public interface IEnemyFactory
{
    IEnemy CreateEnemy(Vector3 position, Quaternion rotation);
    IAttackStrategy CreateAttackStrategy();
}


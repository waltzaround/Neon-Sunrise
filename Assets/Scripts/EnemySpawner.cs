using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public ObjectPooler enemyPool;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemy", 1.0f, 3.0f);
    }

    void SpawnEnemy()
    {
        GameObject enemy = enemyPool.GetPooledObject();
        enemy.SetActive(true);
        enemy.transform.position = GenerateEnemyPosition.GenerateEnemyPositionMethod();
    }

}

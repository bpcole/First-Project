using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    private int wave = 0;
    private int enemiesLeft = 0;
    public GameObject badguyprefab;
    public Transform Spawnlocation;

    void Start()
    {
        SpawnEnemies();
        wave++;
    }

    void Update()
    {
        SpawnEnemies();
        wave++;
    }

    void SpawnEnemies()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        enemiesLeft = enemies.Length;

        do
        {
            Instantiate(badguyprefab, Spawnlocation.position, Spawnlocation.rotation);
        }
        while (enemiesLeft < (wave * 10));
    }
}


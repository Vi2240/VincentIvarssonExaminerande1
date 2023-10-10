using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    [SerializeField] Transform[] spwansPos;
    [SerializeField] GameObject enemy;
    [SerializeField] float time;
    [SerializeField] float repeatRate;

    Vector2 spawnPos; 

    void Start()
    {
        InvokeRepeating("Spawn", time, repeatRate);
    }

    void Spawn()
    {
        int whereToSpawn = Random.Range(0,7);

        spawnPos = new Vector2(spwansPos[whereToSpawn].position.x, spwansPos[whereToSpawn].position.y);

        Instantiate(enemy, spawnPos, Quaternion.identity);
    }
}

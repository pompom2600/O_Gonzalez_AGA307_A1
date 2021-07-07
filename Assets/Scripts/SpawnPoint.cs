using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject[] enemies;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I)) //Instantiate random enemies into random spawns
        {
            int rndEnemy = Random.Range(0, enemies.Length);
            int rndSpawn = Random.Range(0, spawnPoints.Length);
            GameObject enemy = Instantiate(enemies[rndEnemy], spawnPoints[rndSpawn].position, spawnPoints[rndSpawn].rotation);
           
        }
    }

}

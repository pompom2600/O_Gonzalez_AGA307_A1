using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    public Transform[] spawnPoints; //Array for SpawnPoints
    public GameObject[] enemies; //Array for Enemies


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I)) //Instantiate random enemies into random spawns hitting 'I'
        {
            GameManager.instance.Targets++; //Increase Target Numbers
            int rndEnemy = Random.Range(0, enemies.Length);
            int rndSpawn = Random.Range(0, spawnPoints.Length);
            GameObject enemy = Instantiate(enemies[rndEnemy], spawnPoints[rndSpawn].position, spawnPoints[rndSpawn].rotation);
        }
    }

}

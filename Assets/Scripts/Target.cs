using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public TargetSizes sizes;
    private float scaleFactor;

    private float moveDistance = 550;
    private float speed = 4;
    //private float spawnDelay = 3;
    public Transform sP;

    void SetUp()
    {
        switch (sizes)
        {
            case TargetSizes.Medium:
                scaleFactor = 1;
                transform.localScale = Vector3.one * scaleFactor;
                break;

            case TargetSizes.Large:
                scaleFactor = 2;
                transform.localScale = Vector3.one * scaleFactor;
                print("large");
                break;

            case TargetSizes.Small:
                scaleFactor = 0.5f;
                transform.localScale = Vector3.one * scaleFactor;
                break;
        }

    }
    void Start()
    {
        SetUp();
        StartCoroutine(Routine());
    }



    void Update()
    {
     
    }


    IEnumerator Routine()
    {
        for(int i = 0; i < moveDistance; i++)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
            yield return new WaitForSeconds(3f);

            int rndEnemy = Random.Range(0, enemies.Length);
            int rndSpawn = Random.Range(0, spawnPoints.Length);
            GameObject enemy = Instantiate(enemies[rndEnemy], spawnPoints[rndSpawn].position, spawnPoints[rndSpawn].rotation);
        }

    }

}

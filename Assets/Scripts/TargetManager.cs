using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum TargetDifficulty
{
    Hard, Medium, Easy
}

public class TargetManager : Singleton<TargetManager>
{
    public List<Target> targets;
    public TargetDifficulty difficulty;
    public int targetCap = 10;


    void Start()
    {
        foreach (Target t in targets)
        {
            StartCoroutine(t.Routine());
        }
    }
  
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            //targetInstance = Random.Range(0, targets.Length);
        }
    }

   
}


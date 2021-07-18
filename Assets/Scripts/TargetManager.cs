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
    public BoxCollider box;


    void Start()
    {
        StartCoroutine(Routine());
    }
  
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            //targetInstance = Random.Range(0, targets.Length);
        }
    }

    public IEnumerator Routine()
    {
        while (true)
        {
            foreach (Target t in targets)
            {
                Vector3 minbounds = box.bounds.min;
                Vector3 maxbounds = box.bounds.max;         
                Vector3 targetposition = new Vector3(
                   Random.Range(minbounds.x, maxbounds.x),
                   Random.Range(minbounds.y, maxbounds.y),
                   Random.Range(minbounds.z, maxbounds.z));
                Vector3 newposition = Vector3.MoveTowards(t.transform.position, targetposition, t.speed);
                Debug.DrawLine(t.transform.position, targetposition, Color.red, 3f);
                StartCoroutine(t.Move(newposition, 3f));
            }
            yield return new WaitForSeconds(3f);
        }
    }

}


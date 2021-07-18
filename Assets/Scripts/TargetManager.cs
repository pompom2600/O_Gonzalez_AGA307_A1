using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum TargetDifficulty //Enum of target difficulty
{
    Hard, Medium, Easy
}

public class TargetManager : Singleton<TargetManager>
{
    public List<Target> targets; //List of targets
    public TargetDifficulty difficulty;
    public BoxCollider box; //Linear Interpolation things


    void Start()
    {
        StartCoroutine(Routine()); //Start coroutine Routine() on Start
    }
  
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R)) //Attempt at the Week 4 Challenge KeyCode.R Change Sizes
        {
            //targetInstance = Random.Range(0, targets.Length);
        }
    }

    public IEnumerator Routine() //Coroutine Routine
    {
        while (true) //While true do:
        {
            foreach (Target t in targets) //Target (blueprint), t (variable), targets (the Box) NOTE: This is how it works in my head :)
            {
                Vector3 minbounds = box.bounds.min; //getting boundaries min
                Vector3 maxbounds = box.bounds.max; //getting boundaries max
                Vector3 targetPosition = new Vector3( // targetPosition is:
                   Random.Range(minbounds.x, maxbounds.x),
                   Random.Range(minbounds.y, maxbounds.y),
                   Random.Range(minbounds.z, maxbounds.z));
                Vector3 newPosition = Vector3.MoveTowards(t.transform.position, targetPosition, t.speed); // newPosition is:
                Debug.DrawLine(t.transform.position, targetPosition, Color.red, 3f); //Drawing a line to see what's happening (Bug fixing)
                StartCoroutine(t.Move(newPosition, 3f)); //Starting corountine from Target scrimpt
            }
            yield return new WaitForSeconds(3f); //Return after 3seconds
        }
    }

}


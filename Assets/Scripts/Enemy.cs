using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float healthFour = 4; // Health
    private Target target; //Target Reference
    private void Start()
    {
        target = GetComponent<Target>();
    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.collider.CompareTag("Projectile")) //On colision with Projectile do:
        {
            GameManager.instance.Score++; // +1 Score
            GameManager.instance.Timer += 5; // +5 Seconds

            healthFour --; // -1 Target Health
            if (healthFour <= 0) //When Target Health reaches 0 do:
            {
                GameManager.instance.Score += 5; //Gain 5 Points
                GetComponent<Renderer>().material.color = Color.red; //Target material turns red
                if (target != null) // Target Coroutine 
                {
                    target.StopAllCoroutines();
                    TargetManager.instance.targets.Remove(target);
                }
                GameManager.instance.Targets--; //Remove Target number
                Destroy(collision.collider.gameObject); //Destroy
                Destroy(this.gameObject); //Destroy
            }
           
        }

    }
 
}

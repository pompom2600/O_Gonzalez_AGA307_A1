using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float healthFour = 4;
    private Target target;
    private void Start()
    {
        target = GetComponent<Target>();
    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.collider.CompareTag("Projectile"))
        {
            GameManager.instance.Score++;
            GameManager.instance.Timer += 5;

            healthFour --;
            if (healthFour <= 0)
            {
                GameManager.instance.Score += 5;
                GetComponent<Renderer>().material.color = Color.red;
                if (target != null)
                {
                    target.StopAllCoroutines();
                    TargetManager.instance.targets.Remove(target);
                }
                GameManager.instance.Targets--;
                Destroy(collision.collider.gameObject);
                Destroy(this.gameObject, 1f);
            }
           
        }

    }
 
}

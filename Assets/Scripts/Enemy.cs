using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float healthFour = 4;

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.collider.CompareTag("Projectile"))
        {
            healthFour --;
            if (healthFour <= 0)
            {
                GetComponent<Renderer>().material.color = Color.red;
                Destroy(collision.collider.gameObject);
                Destroy(this.gameObject, 1f);
            }
           
        }

    }
 
}

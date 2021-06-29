using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FiringPoint : MonoBehaviour
{
    public GameObject projectile;
    public float projectileSpeed = 100;
    public Transform firingPoint;
    public GameObject[] projectiles;


    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {

            GameObject projectileInstance;

            projectileInstance = Instantiate(projectile, firingPoint.position, firingPoint.rotation);

            projectileInstance.GetComponent<Rigidbody>().AddForce(firingPoint.forward * projectileSpeed, ForceMode.Impulse);

            Destroy(projectileInstance, 3);

        }

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {


        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {


        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {


        }
    }
}

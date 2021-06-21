using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FiringPoint : MonoBehaviour
{
    public GameObject projectile;
    public float projectileSpeed = 100;
    public Transform firingPoint;



    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {

            GameObject projectileInstance;

            projectileInstance = Instantiate(projectile, firingPoint.position, firingPoint.rotation);

            projectileInstance.GetComponent<Rigidbody>().AddForce(firingPoint.forward * projectileSpeed, ForceMode.Impulse);

            Destroy(projectileInstance, 3);

        }

    }
}

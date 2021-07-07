using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FiringPoint : MonoBehaviour
{
    public GameObject projectile;
    public float projectileSpeed = 100;
    public Transform firingPoint;
    public GameObject[] projectiles;
    private int weaponSlot;

    private void Start()
    {
        weaponSlot = 0;
    }
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject projectileInstance;
            projectileInstance = Instantiate(projectiles[weaponSlot], firingPoint.position, firingPoint.rotation);
            projectileInstance.GetComponent<Rigidbody>().AddForce(firingPoint.forward * projectileSpeed, ForceMode.Impulse);
            Destroy(projectileInstance, 3);
        }

        if (Input.GetKey("1"))
        {
            weaponSlot = 0;
            Debug.Log("Weapon 1 Selected");
        }

        if (Input.GetKey("2"))
        {
            weaponSlot = 1;
            Debug.Log("Weapon 2 Selected");
        }

        if (Input.GetKey("3"))
        {
            weaponSlot = 2;
            Debug.Log("Weapon 3 Selected");
        }
    }
}

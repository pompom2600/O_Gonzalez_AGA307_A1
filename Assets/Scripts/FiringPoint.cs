using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FiringPoint : MonoBehaviour
{
    public GameObject projectile; //Projectile reference
    public float projectileSpeed = 100; //Projectile speed
    public Transform firingPoint; //Transform for firingpoint
    public GameObject[] projectiles; //Array for the projectiles
    private int weaponSlot; //Weaponslot

    private void Start()
    {
        weaponSlot = 0;
    }
    void Update()
    {
        if (Input.GetButtonDown("Fire1")) //When left mouse click
        {
            GameObject projectileInstance; //Fire projectile instance
            projectileInstance = Instantiate(projectiles[weaponSlot], firingPoint.position, firingPoint.rotation);
            projectileInstance.GetComponent<Rigidbody>().AddForce(firingPoint.forward * projectileSpeed, ForceMode.Impulse);
            Destroy(projectileInstance, 3); // Destroy after 3 seconds
        }

        if (Input.GetKey("1")) //when press 1 key do:
        {
            weaponSlot = 0;
            Debug.Log("Weapon 1 Selected"); //Called in the console
            UIManager.instance.weaponName.text = "Weapon 1"; //Telling UIManager to replace the text with current weapon
        }

        if (Input.GetKey("2")) //when press 2 key do:
        {
            weaponSlot = 1;
            Debug.Log("Weapon 2 Selected"); //Called in the console
            UIManager.instance.weaponName.text = "Weapon 2"; //Telling UIManager to replace the text with current weapon
        }

        if (Input.GetKey("3")) //when press 3 key do:
        {
            weaponSlot = 2;
            Debug.Log("Weapon 3 Selected"); //Called in the console
            UIManager.instance.weaponName.text = "Weapon 3"; //Telling UIManager to replace the text with current weapon
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerPad : MonoBehaviour
{
    public GameObject sphere; //Variable
    private Color defaultColor; // Variable

    private void Start()
    {
        defaultColor = sphere.GetComponent<Renderer>().material.color; //Setting default colour for sphere
    }

    private void OnTriggerEnter(Collider other) //On triggerEnter
    {
        if (other.CompareTag("Player")) //compare tag "Player"
        {
            sphere.GetComponent<Renderer>().material.color = Color.green; //Setting colour to green
        }
    }
    private void OnTriggerStay(Collider other) //On triggerStay
    {
        if (other.CompareTag("Player")) //compare tag "Player"
        {
            sphere.transform.localScale += Vector3.one * 0.01f; //Change size of Sphere
        }
    }
    private void OnTriggerExit(Collider other) //On triggerExit
    {
        if (other.CompareTag("Player")) // Compare tag "Player"
        {
            sphere.transform.localScale = Vector3.one; //Revert Scale
            sphere.GetComponent<Renderer>().material.color = defaultColor; // Revert colour
        }
    }
}

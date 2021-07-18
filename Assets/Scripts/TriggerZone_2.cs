using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerZone_2 : MonoBehaviour
{
    //Sphere
    public GameObject sphere2;
    private Color defaultColor;
    private GameObject sight;
    private Renderer sphereRenderer;

    // Raycasting
    public float maxDistance = 200;
    int layerMask;
    
    private void Start()
    {
        //int layerMask = LayerMask.GetMask("Ray"); Another way to say it
        layerMask = 1 << LayerMask.NameToLayer("Ray");
        sphereRenderer = sphere2.GetComponent<Renderer>();
        sight = GetComponentInChildren<Camera>().gameObject;
        defaultColor = sphereRenderer.material.color;
    }
 
    private void OnTriggerStay(Collider other)
    {
        Debug.Log(other.name);
       
        if (other.CompareTag("Zone")) //When in the zone
        {
            Debug.DrawLine(sight.transform.position, sight.transform.position + sight.transform.forward * 3, Color.yellow); //Draw raycast line
            RaycastHit hit;
            UIManager.instance.SphereChange.SetActive(true); //UIManager message for player appears
            if (Input.GetKey(KeyCode.E))
            {
                sphereRenderer.material.color = Color.red; //Hit 'E' to change colour to Red
            }

            else
            {
                sphereRenderer.material.color = defaultColor; //Else change to default
            }

            //Vector3 fwd = transform.TransformDirection(Vector3.forward); Another way
            if (Physics.Raycast(sight.transform.position, sight.transform.forward, out hit, maxDistance, layerMask))
            {
                sphere2.transform.localScale += Vector3.one * 0.01f; //Increase Sphere size when raycast hits
            }
            
            else
            {
                sphere2.transform.localScale = Vector3.one; //Else revert to default // Vector3.one
            }
        }
    }

    void OnTriggerExit(Collider other) //On TriggerExit
    {
        if (other.CompareTag("Zone")) //On exit from the "Zone" revert to default.
        {
            sphere2.transform.localScale = Vector3.one;
            sphereRenderer.material.color = defaultColor;
            UIManager.instance.SphereChange.SetActive(false);
        }
    }

}

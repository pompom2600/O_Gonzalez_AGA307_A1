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

        if (other.CompareTag("Zone"))
        {
            Debug.DrawLine(sight.transform.position, sight.transform.position + sight.transform.forward * 3, Color.yellow);
            RaycastHit hit;

            if (Input.GetKey(KeyCode.E))
            {
                sphereRenderer.material.color = Color.red;
            }

            else
            {
                sphereRenderer.material.color = defaultColor;
            }

            //Vector3 fwd = transform.TransformDirection(Vector3.forward);
            if (Physics.Raycast(sight.transform.position, sight.transform.forward, out hit, maxDistance, layerMask))
            {
                Debug.Log("potato");
                sphere2.transform.localScale += Vector3.one * 0.01f;
            }
            
            else
            {
                sphere2.transform.localScale = Vector3.one;
            }
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Zone"))
        {
            sphere2.transform.localScale = Vector3.one;
            sphereRenderer.material.color = defaultColor;
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{

    public float mouseSensitivity = 50f; //MouseSensitivity
    public Transform playerBody; //Body Transform
    float xRotation = 0f; //xRotation

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; //On Start Lock Cursor
    }
   
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime; //Camera movement using X & Y * Mousesensisitivity * Time.deltatime
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f); // Clamping Camera
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f); //Camera Rotation 
        playerBody.Rotate(Vector3.up * mouseX); 
        


    }
}

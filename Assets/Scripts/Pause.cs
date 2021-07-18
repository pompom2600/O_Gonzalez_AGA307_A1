using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public GameObject pausePanel; //Pausepanel reference
    bool isPaused = false; //Bool for the pause panel

    private void Start()
    {
        pausePanel.SetActive(false); //Panel is not active on the start of game
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) //When ESC is hit toggle pause
        {
            TogglePause();
        }
    }
 
    public void TogglePause()
    {
        isPaused = !isPaused;

        if (isPaused) //if paused then do:
        {
            pausePanel.SetActive(true); //Panel set to true
            Time.timeScale = 0; // Time stops
            Cursor.lockState = CursorLockMode.None; //cursor is unlocked
        }
        else //if else:
        {
            pausePanel.SetActive(false); //Return things to normal
            Time.timeScale = 1;
        }
    }
}

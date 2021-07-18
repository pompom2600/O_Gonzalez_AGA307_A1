using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class UITitle : MonoBehaviour
{

    public void LoadScene(string _sceneName) //LoadScene through a string
    {
        SceneManager.LoadScene(_sceneName);
    }


    public void StartGame() //Startgame loads scene "SampleScene"
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void QuitGame() //QuitGame = application quit
    {
        Application.Quit();
    }
 
}

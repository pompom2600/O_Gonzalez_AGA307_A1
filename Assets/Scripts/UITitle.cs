using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class UITitle : MonoBehaviour
{

    public void LoadScene(string _sceneName)
    {
        SceneManager.LoadScene(_sceneName);
    }


    public void StartGame()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
 
}

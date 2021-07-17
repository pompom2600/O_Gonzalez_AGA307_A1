using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : Singleton<UIManager>
{
    public TMP_Text scoreCount;
    public TMP_Text enemiesLeft;
    public TMP_Text difficultyCount;
    public TMP_Text timerCount;


    void Start()
    {
        
    }

    
    void Update()
    {
        scoreCount.text = "Score: " + GameManager.instance.Score;
        timerCount.text = "Timer: " + GameManager.instance.Timer;
        enemiesLeft.text = "Targets Left: " + GameManager.instance.Targets;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : Singleton<UIManager>
{
    public TMP_Text scoreCount;
    public TMP_Text enemiesLeft;
    public TMP_Text weaponName;
    public TMP_Text timerCount;

    public GameObject SphereChange;


    void Start()
    {
        SphereChange.SetActive(false);
        weaponName.text = "Weapon 1";
    }

    
    void Update()
    {
        scoreCount.text = "Score: " + GameManager.instance.Score;
        timerCount.text = "Timer: " + GameManager.instance.Timer;
        enemiesLeft.text = "Targets Left: " + GameManager.instance.Targets;
    }
}

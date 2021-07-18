using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : Singleton<UIManager>
{
    public TMP_Text scoreCount; //Text variables
    public TMP_Text enemiesLeft;
    public TMP_Text weaponName;
    public TMP_Text timerCount;

    public GameObject SphereChange; //GO variable


    void Start() //On start sphere is false and weaponName is 1
    {
        SphereChange.SetActive(false); 
        weaponName.text = "Weapon 1";
    }

    
    void Update()
    {
        scoreCount.text = "Score: " + GameManager.instance.Score; //Updates Score Count
        timerCount.text = "Timer: " + GameManager.instance.Timer.ToString("0.00"); //Updates Timer Count.00
        enemiesLeft.text = "Targets Left: " + GameManager.instance.Targets; //Updates Target Count
    }
}

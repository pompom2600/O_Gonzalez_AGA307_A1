using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public TargetDifficulty sizes; //Enum of TargetSizes from TargetManager
    private float scaleFactor; //Scale Factor
    public float speed; 

    void SetUp()
    {
        switch (sizes) //Switch Statement
        {
            case TargetDifficulty.Medium:
                GameManager.instance.Targets++; //Increase Target Number
                scaleFactor = 1; //Scale Factor
                speed = 12; //Speed Factor
                transform.localScale = Vector3.one * scaleFactor; //Change the scale
                GetComponent<Renderer>().material.color = Color.yellow; //Material Colour change
                break;

            case TargetDifficulty.Easy:
                GameManager.instance.Targets++;
                scaleFactor = 2;
                speed = 10;
                transform.localScale = Vector3.one * scaleFactor;
                GetComponent<Renderer>().material.color = Color.green;
                break;

            case TargetDifficulty.Hard:
                GameManager.instance.Targets++;
                scaleFactor = 0.5f;
                speed = 15;
                transform.localScale = Vector3.one * scaleFactor;
                GetComponent<Renderer>().material.color = Color.red;
                break;
        }
    }
    public IEnumerator Move (Vector3 targetPosition, float moveTime) //Coroutine for moving Targets overtime
    {
        Vector3 originalPosition = transform.position;
        float elapseTime = 0;
        
        while(this != null && elapseTime < moveTime){ //not null && While elsapse time is less than movetime:
            elapseTime += Time.deltaTime;
            transform.position = Vector3.Lerp(originalPosition, targetPosition, elapseTime / moveTime); //Linear Interpolation

            yield return null; //yeet that null
        }
    }
    void Start()
    {
        SetUp(); //Call Setup at Start
    }

    private void OnDestroy()
    {
        StopAllCoroutines(); //Fixing dem bugs yo
    }
}

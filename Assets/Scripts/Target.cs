using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public TargetDifficulty sizes;
    private float scaleFactor;

    
    private float moveDistance = 500;
    public float speed = 20;

    void SetUp()
    {
        switch (sizes)
        {
            case TargetDifficulty.Medium:
                GameManager.instance.Targets++;
                scaleFactor = 1;
                speed = 12;
                transform.localScale = Vector3.one * scaleFactor;
                GetComponent<Renderer>().material.color = Color.yellow;
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

    void Start()
    {
        SetUp();
       
    }

    public IEnumerator Routine()
    {
        while (gameObject != null)
        {
            transform.Translate(Vector3.left * speed);

            yield return new WaitForSeconds(3f);
            print("sdtrawberry");
        }
        yield return null;
    }
}

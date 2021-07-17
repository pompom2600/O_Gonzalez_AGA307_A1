using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameState
{
    Title, InGame
}

public class GameManager : Singleton<GameManager>
{
    public int Score = 0;
    public float Timer = 30f;
    public int Targets = 0;
    public GameState gameState;

    void Start()
    {
        
    }
    public void Update()
    {
        if (gameState == GameState.InGame)
            Timer -= Time.deltaTime;
      
    }
 
}

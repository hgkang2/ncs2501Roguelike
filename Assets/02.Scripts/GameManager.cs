using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance {get; private set;}
    public BoardManager BoardManager;
    public PlayerController PlayerController;
    private int m_FoodAmount = 100;

    public TurnManager TurnManager {get;private set;}
    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
    }
    void Start()
    {
        TurnManager = new TurnManager();
        TurnManager.OnTick += OnTurnHappen;
        
        BoardManager.Init();
        PlayerController.Spawn (BoardManager,new Vector2Int(1,1));
    }

    void OnTurnHappen()
    {
        m_FoodAmount --;
        Debug.Log($"Current amount of food : {m_FoodAmount}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

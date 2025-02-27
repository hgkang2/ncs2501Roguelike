using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Tilemaps;
using UnityEngine;
using UnityEngine.UIElements;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance {get; private set;}
    public BoardManager BoardManager;
    public PlayerController PlayerController;
    public UIDocument UIDoc;
    public TurnManager TurnManager {get;private set;}
    private Label m_FoodLabel;
    private int m_FoodAmount = 100;

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
        m_FoodLabel = UIDoc.rootVisualElement.Q<Label>("FoodLabel");
        m_FoodLabel.text = $"Food : {m_FoodAmount}";
        TurnManager = new TurnManager();
        TurnManager.OnTick += OnTurnHappen;
        
        BoardManager.Init();
        PlayerController.Spawn (BoardManager,new Vector2Int(1,1));
    }

    void OnTurnHappen()
    {
        m_FoodAmount --;
        m_FoodLabel.text =$"Food:{m_FoodAmount:000}";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

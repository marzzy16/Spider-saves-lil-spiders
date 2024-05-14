using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;


public class PlayerHealth : MonoBehaviour
{
    private UIManager uIManager;
    public static event Action OnPlayerDamaged;
    public static event Action OnPlayerDeath;
    public GameOver game;
    public ScoreManager score;
    public GameManagerScript GameManager;
    public float health, maxHealth;

    public UIManager uiManager { get; private set; }

    void Start()
    {
        health = maxHealth;
    }

    private void Awake()
    {
        uiManager = FindObjectOfType<UIManager>();
    }

    public void TakeDamage(float amount)
    {
        health -= amount;
        OnPlayerDamaged?.Invoke();
        uiManager.GameOver();


        if (health <= 0)
        {
            health = 0;
            game.Setup(score.score);
            GameManager.gameOver();
            Debug.Log("You're dead");
            OnPlayerDeath?.Invoke();
        }
    }

} 

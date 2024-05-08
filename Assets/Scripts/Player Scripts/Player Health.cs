using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public static event Action OnPlayerDamaged;
    public static event Action OnPlayerDeath;
    public GameManagerScript game;
    public float health, maxHealth;


    void Start()
    {
        health = maxHealth;
    }

   public void TakeDamage(float amount)
    {
        health -= amount;
        OnPlayerDamaged?.Invoke();


        if (health <= 0)
        {
            health = 0;
            GameManagerScript.gameover();
            Debug.Log("You're dead");
            OnPlayerDeath?.Invoke();
        }
    }

} 

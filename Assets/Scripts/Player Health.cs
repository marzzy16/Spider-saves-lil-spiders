using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float maxHealth = 100f;
    public float currentHealth;

    public HealthBar healthbar;

    void Start()
    {
        currentHealth = maxHealth;
    }

   public void TakeDamage(float damageAmout)
    {
      currentHealth -= damageAmout;

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Debug.Log("Player has died");
    }
  
} 

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider Healthslider;
    public PlayerHealth playerHealth;

   void Start()
    {
        if (Healthslider != null) 
        {
            Debug.LogError("Health Bar not assigned to Health Bar script.");
        }

        if (playerHealth == null)
        {
            Debug.LogError("Player Health script not assignd to HealthBar script.");
        }

#pragma warning disable CS8321 // Local function is declared but never used
        void Update()
        {
          Healthslider.value = playerHealth.currentHealth / playerHealth.maxHealth;
        }
#pragma warning restore CS8321 // Local function is declared but never used


    }
}

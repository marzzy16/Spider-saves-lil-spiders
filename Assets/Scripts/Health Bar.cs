using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public GameObject heartPrefab;
    public PlayerHealth playerHealth;
    List<HealthHearts> hearts = new List<HealthHearts>();
          private void OnEnable()
            {
        PlayerHealth.OnPlayerDamaged += DrawHearts;
            }

    private void OnDisable()
    {
        PlayerHealth.OnPlayerDamaged += DrawHearts;
    }

    private void Start()
    {
       DrawHearts();
    }

    public void DrawHearts()
    {
        ClearHearts();

        // determine how many hearts to make total
        // based off the max health
        float maxHealthRemainder = playerHealth.maxHealth % 2; // 1
        int heartsToMake = (int)((playerHealth.maxHealth /2) + maxHealthRemainder);
        for(int i = 0; i < heartsToMake; i++)

         
        {
            CreateEmptyHeart(); // make totlal hears needed
        }

        for(int i = 0; i < hearts.Count; i++)
        {
            int heartStatusReminder =(int)Mathf.Clamp(playerHealth.health - (i*2), 0, 2);
            hearts[i].SetHeartImage((HeartStatus)heartStatusReminder);
        }
    }

    public void CreateEmptyHeart()
    {
        GameObject newHeart = Instantiate(heartPrefab);
        newHeart.transform.SetParent(transform);

        HealthHearts heartComponent  = newHeart.GetComponent<HealthHearts>();
        heartComponent.SetHeartImage(HeartStatus.Empty);
        hearts.Add(heartComponent);
    }

    public void ClearHearts()
    {
        foreach(Transform t in transform)
        {
            Destroy(t.gameObject); 
        }
        hearts = new List<HealthHearts>(); 
    }
}

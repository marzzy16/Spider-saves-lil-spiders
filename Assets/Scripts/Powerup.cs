using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerup : MonoBehaviour
{
    public float multiplir = 1.4f;

    public GameObject PickupEffect;

    private void OnAnimatorIK(int layerIndex)
    {
       void onTriggerEnter(Collider other) 
        { 
         if (other.CompareTag("Player"))
            {
                Pickup(other);
            }

        }

        void Pickup(Collider player)
        {
            Instantiate(PickupEffect, transform.position, transform.rotation);  

            PlayerHealth health = player.GetComponent<PlayerHealth>();
            health.health *= multiplir;
            Destroy(gameObject);
        }

    }
}

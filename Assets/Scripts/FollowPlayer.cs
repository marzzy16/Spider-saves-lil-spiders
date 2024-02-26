using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public float speed;
    public float jump;

    private void Update()
    {
        if (player != null)
            
        {
            Vector3 direction = player.position - transform.position;
            direction.Normalize();

            transform.Translate(direction * speed * Time.deltaTime);
        }
    }
}

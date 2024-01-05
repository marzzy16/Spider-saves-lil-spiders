using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    bool movingRight;
    [SerializeField] float moveSpeed = 1f;

    Rigidbody2D myRigidbody;
    BoxCollider2D myBoxCollider;

    private void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
        myBoxCollider = GetComponent<BoxCollider2D>();
       InvokeRepeating("Enemy", 0f, 0f);
    }
    private void Update()
    {
        if (movingRight)
        {
            myRigidbody.velocity = new Vector2(moveSpeed, 0f);
        }
        else
        {
            myRigidbody.velocity = new Vector2(-moveSpeed, 0f);
        }
    }
    private bool changeDir()
    {
        return !movingRight;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        transform.position = new Vector2(-(Mathf.Sign(myRigidbody.velocity.x)), transform.localScale.y);

    }
}

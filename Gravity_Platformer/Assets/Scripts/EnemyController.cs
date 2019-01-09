using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    #region Variables
    float patrolTime = 1.0f;
    float patrolForce = 200f;

    float patrolTimer;
    Vector2 direction;

    #endregion


    private void Start()
    {
        this.direction = Vector2.right * (Random.Range(0f, 1f) > 0.5 ? 1 : -1);
    }

    private void Update()
    {
        patrolTimer += Time.deltaTime;

        if (patrolTimer >= patrolTime)
        {
            this.GetComponent<Rigidbody2D>().velocity = Vector2.zero;

            patrolTimer = 0;
            direction *= -1;
        }

        this.GetComponent<Rigidbody2D>().AddForce(this.direction * patrolForce * Time.deltaTime);
    }



} // main class

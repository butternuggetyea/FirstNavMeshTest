using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class DuckBehavior : MonoBehaviour
{
    public static event Action<DuckBehavior> onEnemyKilled;
    [SerializeField] float health, maxHealth = 3f;

    [SerializeField] float moveSpeed = 5f;
   private Rigidbody rb;
    Transform target;
    Vector3 moveDirection;



    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Start()
    {
        health = maxHealth;
        target = GameObject.Find("Player").transform;
    }

    void Update()
    {
       

    

    }

    void FixedUpdate()
    {

    }

    public void TakeDamage(float damageAmount) {
        Debug.Log($"Damage Amount:{damageAmount}");
        health -= damageAmount;
        Debug.Log($"Health is now: {health}");

        if (health <= 0) {
            Destroy(gameObject);
            onEnemyKilled?.Invoke(this);
            onEnemyKilled?.Invoke(this);
        
        
        }
    
    
    }

    // Update is called once per frame

}

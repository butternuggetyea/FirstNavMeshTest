using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodDuck : MonoBehaviour
{
    public static event Action<WoodDuck> onEnemyKilled;
    [SerializeField] float health, maxHealth = 3f;

    [SerializeField] float moveSpeed = 5f;
    private Rigidbody rb;
    Transform target;
    Vector3 moveDirection;

    [SerializeField] static int WoodDuckDeaths = 0;

    Weapon weapon;

    private bool FoundWeapon = false;

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

    private void OnTriggerEnter(Collider other)




    {
        if (other.gameObject.tag == "Weapon")
        {
            if (FoundWeapon == true)
            {
                weapon.EnemysKilled = WoodDuckDeaths;
                if (WoodDuckDeaths >= 100)
                {
                    FoundWeapon = false;

                }
            }
            WoodDuckDeaths++;
            Debug.Log("hitDuck");
            FoundWeapon = true;
            weapon = other.gameObject.GetComponent<Weapon>();
        }

    }

    public void TakeDamage(float damageAmount)
    {
        Debug.Log($"Damage Amount:{damageAmount}");
        health -= damageAmount;
        Debug.Log($"Health is now: {health}");

        if (health <= 0)
        {
            Destroy(gameObject);
            onEnemyKilled?.Invoke(this);
            onEnemyKilled?.Invoke(this);


        }


    }

}

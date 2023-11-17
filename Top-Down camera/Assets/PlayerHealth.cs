using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Schema;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public static event Action<PlayerHealth> onEnemyKilled;
    [SerializeField] float health, maxHealth = 3f;




    private float BuffTotal;
    private float TotalHealth;

  



    //buff names here
    private float buffname;

    private void Awake()
    {
   
    }

    void Start()
    {

        Buffs();
        TotalHealth = maxHealth + BuffTotal;
        health = TotalHealth;
        
    }

    void Update()
    {
        Buffs();
        TotalHealth = maxHealth + BuffTotal;

        if (Input.GetKeyDown(KeyCode.H)) { health = TotalHealth; }
    }

    private void Buffs() 
    {
        
        bool hasbuff = true;
        if (hasbuff) { buffname = (maxHealth / 100) * 15; }

        BuffTotal = buffname + buffname;
    }


    void FixedUpdate()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "enemy") { TakeDamage(1); }
    }




    public void TakeDamage(float damageAmount)
    {
        Debug.Log($"Damage Amount:{damageAmount}");
        health -= damageAmount;
        Debug.Log($"Health is now: {health}");

        if (health <= 0)
        {


            onEnemyKilled?.Invoke(this);



        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrogmanBehavior : MonoBehaviour
{
    public static event Action<FrogmanBehavior> onEnemyKilled;
    [SerializeField] float health, maxHealth = 3f;

    [SerializeField] float moveSpeed = 5f;
    private Rigidbody rb;
    Transform target;
    Vector3 moveDirection;

    [SerializeField] static int Deaths = 0;

    public int NumOfSoulStones;

    Weapon weapon;

    private bool FoundWeapon = false;

    public GameObject MainObj;

    SoulStoneLogic soulStoneLogic;

    middleman Middleman;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Start()
    {
        Middleman = FindAnyObjectByType<middleman>();
        soulStoneLogic = FindAnyObjectByType<SoulStoneLogic>();
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
          
            TakeDamage(middleman.TotalDamage);
            Debug.Log("Hit");

        }

    }

    public void TakeDamage(float damageAmount)
    {
        Debug.Log($"Damage Amount:{damageAmount}");
        health -= damageAmount;
        Debug.Log($"Health is now: {health}");

        if (health <= 0)
        {
            for (int i = 0; i < NumOfSoulStones; i++)
            {
                StartCoroutine(soulStoneLogic.SpawnSoulStone());
            }
            Destroy(MainObj.gameObject);
            Deaths++;
            onEnemyKilled?.Invoke(this);



        }
    }
}

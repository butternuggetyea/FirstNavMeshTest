using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using static UnityEngine.EventSystems.EventTrigger;

public class DuckBehavior : MonoBehaviour
{
    public static event Action<DuckBehavior> onEnemyKilled;
    [SerializeField] float health, maxHealth = 3f;

    [SerializeField] float moveSpeed = 5f;
   private Rigidbody rb;
    Transform target;
    Vector3 moveDirection;

   [SerializeField] static int DuckDeaths = 0;

    public int NumOfSoulStones;
        
    Weapon weapon;

    private bool FoundWeapon = false;

    public GameObject SoulStone;

    public GameObject MainObj;

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
                weapon.EnemysKilled = DuckDeaths;
                if (DuckDeaths >= 100)
                {
                    FoundWeapon = false;

                }
            }
            DuckDeaths++;
            TakeDamage(1);
            Debug.Log("hitDuck");
            FoundWeapon = true;
            weapon = other.gameObject.GetComponent<Weapon>();
        }

    }

    public void TakeDamage(float damageAmount) {
        Debug.Log($"Damage Amount:{damageAmount}");
        health -= damageAmount;
        Debug.Log($"Health is now: {health}");

        if (health <= 0) {
            for (int i = 0; i < NumOfSoulStones; i++)
            {
                StartCoroutine(SpawnSoulStone());
            }
            Destroy(MainObj.gameObject);
            onEnemyKilled?.Invoke(this);
            
        
        
        }
    }
    IEnumerator SpawnSoulStone() {

      
            Instantiate(SoulStone, new Vector3(this.transform.position.x, this.transform.position.y+3, this.transform.position.z), Quaternion.Euler(0, 0, 0));

        yield return new WaitForSeconds(.5f); }

    

    // Update is called once per frame

}

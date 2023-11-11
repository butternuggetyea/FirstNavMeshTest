using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class EnemyFollow : MonoBehaviour
{
    public NavMeshAgent enemy;
    Transform player;
    private bool InRange = false;

    
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (InRange) { 
      
         enemy.SetDestination(player.position);}
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            InRange = true;
            Debug.Log("works");



        }
    }
         void OnTriggerExit(Collider other)
        {


            if (other.gameObject.tag == "Player")
            {
                InRange = false;
                Debug.Log("works");



            }
        }
    

    

}

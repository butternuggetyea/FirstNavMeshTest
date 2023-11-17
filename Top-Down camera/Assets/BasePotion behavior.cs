using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasePotionbehavior : MonoBehaviour
{
    middleman Middleman;
    private float TotalDamage = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        middleman.TotalDamage = TotalDamage;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "Player")
        {
            Debug.Log("Hit");
            Destroy(gameObject);
        }
    }

}

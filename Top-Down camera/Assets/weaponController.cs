using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weaponController : MonoBehaviour
{
    public GameObject Dagger;
    public bool CanAttack = true;
    public float AttackCooldown = 1.0f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {

            if (CanAttack)
            {

                DaggerAttack();
            }

        }

    }

    public void DaggerAttack() {

        CanAttack = false;
        Animator anim = Dagger.GetComponent<Animator>();
        anim.SetTrigger("attack");
        StartCoroutine(ResetAttackCooldown());
    
    }

    IEnumerator ResetAttackCooldown() {

        yield return new WaitForSeconds(AttackCooldown);
        CanAttack = true;
    
    }

}

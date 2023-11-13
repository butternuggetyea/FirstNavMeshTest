using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoulStoneLogic : MonoBehaviour
{
    

    bool AddStone;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player") 
        {
            this.transform.position = other.gameObject.transform.position;
        }
    }


}

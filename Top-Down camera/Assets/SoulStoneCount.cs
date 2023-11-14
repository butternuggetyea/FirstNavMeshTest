using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoulStoneCount : MonoBehaviour
{

    public GameObject MainObj;

    static int SoulStones = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            Debug.Log(SoulStones);
        }
    }
    private void OnTriggerEnter(Collider other)
    
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(MainObj.gameObject);
            SoulStones = SoulStones + 1;

        }
    }


}

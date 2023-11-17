using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoulStoneLogic : MonoBehaviour
{
   public GameObject SoulStone;

    bool AddStone;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public IEnumerator SpawnSoulStone()
    {


        Instantiate(SoulStone, new Vector3(this.transform.position.x, this.transform.position.y + 3, this.transform.position.z), Quaternion.Euler(0, 0, 0));

        yield return new WaitForSeconds(.5f);
    }

}

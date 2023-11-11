using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainPosition : MonoBehaviour
{
    public float PosX, PosZ;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Terrain")
        {
            PosX = other.gameObject.transform.position.x;

            PosZ = other.gameObject.transform.position.z;
        }

    }

}

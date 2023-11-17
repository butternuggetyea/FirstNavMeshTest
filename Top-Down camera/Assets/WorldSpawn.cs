using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class WorldSpawn : MonoBehaviour
{

  
    // Start is called before the first frame update

    private static List<GameObject> Terrains;

    void Start()
    {

        LoadList();
 
        Ring4();
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    private void Ring4()
    {

        int RVectorX, RVectorZ;

        RVectorX = -2000;
        RVectorZ = -2000;

        
        for (int i = 0; i < 7; i++)
        {
            RVectorZ += 500;
            for (int j = 0; j < 7; j++)
            {
                RVectorX += 500;
                int RandomTerrain = Random.Range(0, Terrains.Count);
                Instantiate(Terrains[RandomTerrain], new Vector3(RVectorX, 0, RVectorZ), Quaternion.Euler(0, 0, 0));
            }
            RVectorX = -2000;
        }

    }


    private void LoadList() {


        Terrains = new List<GameObject>(Resources.LoadAll<GameObject>("TerrainSpawns"));



    }



}



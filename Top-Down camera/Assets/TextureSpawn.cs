using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextureSpawn : MonoBehaviour
{


    // Start is called before the first frame update

    private static List<GameObject> Pixels;

    void Start()
    {

        LoadList();
        SpawnTerrain();
    }

    // Update is called once per frame
    void Update()
    {

    }



    private void SpawnTerrain()
    {

        float VectorX = -5f; 
        float VectorZ = -5f;

        
        for (int i = 1; i < 100; i++)
        {
            Debug.Log(VectorZ);
            VectorZ += 5f;
            for ( int j = 1 ; j < 100; j++)
            {
                VectorX += 5f;
                int RandomPixel = Random.Range(0, Pixels.Count);
                Instantiate(Pixels[RandomPixel], new Vector3(VectorX, 0, VectorZ), Quaternion.Euler(0, 0, 0));
            }
            VectorX = -5f;
            
        }

    }


    private void LoadList()
    {


        Pixels = new List<GameObject>(Resources.LoadAll<GameObject>("TextureSpawn"));



    }
}

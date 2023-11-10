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
        Center();
        Ring1();
        Ring2();
        Ring3();
        Ring4();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void Center()
    {
        int CVectorX, CVectorZ;
        CVectorX = 0;
        CVectorZ = 0;

        int RandomTerrain = Random.Range(0, Terrains.Count);
        for (int i = 1; i <= 4; i++)
        {
            if (i == 2) { CVectorZ = -750; }
            if (i == 3) { CVectorX = -750; }
            if (i == 4) { CVectorZ = 0; }
            Instantiate(Terrains[RandomTerrain], new Vector3(CVectorX, 0, CVectorZ), Quaternion.Euler(0, 0, 0));
        }


    }

    private void Ring1() {
        Q1R1();
        Q2R1();
        Q3R1();
        Q4R1();
    }

   private void Q1R1() {
        int RVectorX, RVectorZ;

        RVectorX = 750;
        RVectorZ = 0;

        int RandomTerrain = Random.Range(0, Terrains.Count);
        for (int i = 1; i <= 3; i++)
        {
            if (i == 2) { RVectorZ = 750; }
            if (i == 3) { RVectorX = 0; }
            Instantiate(Terrains[RandomTerrain], new Vector3(RVectorX, 0, RVectorZ), Quaternion.Euler(0, 0, 0));
        }

    }

    private void Q2R1()
    {
        int RVectorX, RVectorZ;

        RVectorX = -1500;
        RVectorZ = 0;

        int RandomTerrain = Random.Range(0, Terrains.Count);
        for (int i = 1; i <= 3; i++)
        {
            if (i == 2) { RVectorZ = 750; }
            if (i == 3) { RVectorX = -750; }
            Instantiate(Terrains[RandomTerrain], new Vector3(RVectorX, 0, RVectorZ), Quaternion.Euler(0, 0, 0));
        }
    }

   private void Q3R1()
    {
        int RVectorX, RVectorZ;

        RVectorX = -1500;
        RVectorZ = -750;

        int RandomTerrain = Random.Range(0, Terrains.Count);
        for (int i = 1; i <= 3; i++)
        {
            if (i == 2) { RVectorZ = -1500; }
            if (i == 3) { RVectorX = -750; }
            Instantiate(Terrains[RandomTerrain], new Vector3(RVectorX, 0, RVectorZ), Quaternion.Euler(0, 0, 0));
        }
    }

   private void Q4R1()
    {
        int RVectorX, RVectorZ;

        RVectorX = 750;
        RVectorZ = -750;

        int RandomTerrain = Random.Range(0, Terrains.Count);
        for (int i = 1; i <= 3; i++)
        {
            if (i == 2) { RVectorZ = -1500; }
            if (i == 3) { RVectorX = 0; }
            Instantiate(Terrains[RandomTerrain], new Vector3(RVectorX, 0, RVectorZ), Quaternion.Euler(0, 0, 0));
        }
    }

    private void Ring2()
    {
        Q1R2();
        Q2R2();
        Q3R2();
        Q4R2();
    }

    private void Q1R2()
    {
        int RVectorX, RVectorZ;

        RVectorX = -2250;
        RVectorZ = 0;

        int RandomTerrain = Random.Range(0, Terrains.Count);
        for (int i = 1; i <= 5; i++)
        {
            if (i == 2) { RVectorZ = 750; }
            if (i == 3) { RVectorZ = 1500; }
            if (i == 4) { RVectorX = -1500; }
            if (i == 5) { RVectorX = -750; }
            Instantiate(Terrains[RandomTerrain], new Vector3(RVectorX, 0, RVectorZ), Quaternion.Euler(0, 0, 0));
        }

    }

    private void Q2R2()
    {
        int RVectorX, RVectorZ;

        RVectorX = 1500;
        RVectorZ = 0;

        int RandomTerrain = Random.Range(0, Terrains.Count);
        for (int i = 1; i <= 5; i++)
        {
            if (i == 2) { RVectorZ = 750; }
            if (i == 3) { RVectorZ = 1500; }
            if (i == 4) { RVectorX = 750; }
            if (i == 5) { RVectorX = 0; }
            Instantiate(Terrains[RandomTerrain], new Vector3(RVectorX, 0, RVectorZ), Quaternion.Euler(0, 0, 0));
        }
    }

    private void Q3R2()
    {
        int RVectorX, RVectorZ;

        RVectorX = 1500;
        RVectorZ = -750;

        int RandomTerrain = Random.Range(0, Terrains.Count);
        for (int i = 1; i <= 5; i++)
        {
            if (i == 2) { RVectorZ = -1500; }
            if (i == 3) { RVectorZ = -2250; }
            if (i == 4) { RVectorX = 750; }
            if (i == 5) { RVectorX = 0; }
            Instantiate(Terrains[RandomTerrain], new Vector3(RVectorX, 0, RVectorZ), Quaternion.Euler(0, 0, 0));
        }
    }

    private void Q4R2()
    {
        int RVectorX, RVectorZ;

        RVectorX = -2250;
        RVectorZ = -750;

        int RandomTerrain = Random.Range(0, Terrains.Count);
        for (int i = 1; i <= 5; i++)
        {
            if (i == 2) { RVectorZ = -1500; }
            if (i == 3) { RVectorZ = -2250; }
            if (i == 4) { RVectorX = -1500; }
            if (i == 5) { RVectorX = -750; }
            Instantiate(Terrains[RandomTerrain], new Vector3(RVectorX, 0, RVectorZ), Quaternion.Euler(0, 0, 0));
        }
    }

    private void Ring3()
    {

        Q1R3();
        Q2R3();
        Q3R3();
        Q4R3();

    }

    private void Q1R3()
    {
        int RVectorX, RVectorZ;

        RVectorX = -3000;
        RVectorZ = 0;

        int RandomTerrain = Random.Range(0, Terrains.Count);
        for (int i = 1; i <= 7; i++)
        {
            if (i == 2) { RVectorZ = 750; }
            if (i == 3) { RVectorZ = 1500; }
            if (i == 4) { RVectorZ = 2250; }
            if (i == 5) { RVectorX = -2250; }
            if (i == 6) { RVectorX = -1500; }
            if (i == 7) { RVectorX = -750; }
            Instantiate(Terrains[RandomTerrain], new Vector3(RVectorX, 0, RVectorZ), Quaternion.Euler(0, 0, 0));
        }

    }

    private void Q2R3()
    {
        int RVectorX, RVectorZ;

        RVectorX = 2250;
        RVectorZ = 0;

        int RandomTerrain = Random.Range(0, Terrains.Count);
        for (int i = 1; i <= 7; i++)
        {
            if (i == 2) { RVectorZ = 750; }
            if (i == 3) { RVectorZ = 1500; }
            if (i == 4) { RVectorZ = 2250; }
            if (i == 5) { RVectorX = 1500; }
            if (i == 6) { RVectorX = 750; }
            if (i == 7) { RVectorX = 0; }
            Instantiate(Terrains[RandomTerrain], new Vector3(RVectorX, 0, RVectorZ), Quaternion.Euler(0, 0, 0));
        }

    }

    private void Q3R3()
    {
        int RVectorX, RVectorZ;

        RVectorX = -3000;
        RVectorZ = -750;

        int RandomTerrain = Random.Range(0, Terrains.Count);
        for (int i = 1; i <= 7; i++)
        {
            if (i == 2) { RVectorZ = -1500; }
            if (i == 3) { RVectorZ = -2250; }
            if (i == 4) { RVectorZ = -3000; }
            if (i == 5) { RVectorX = -2250; }
            if (i == 6) { RVectorX = -1500; }
            if (i == 7) { RVectorX = -750; }
            Instantiate(Terrains[RandomTerrain], new Vector3(RVectorX, 0, RVectorZ), Quaternion.Euler(0, 0, 0));
        }

    }

    private void Q4R3()
    {
        int RVectorX, RVectorZ;

        RVectorX = 2250;
        RVectorZ = -750;

        int RandomTerrain = Random.Range(0, Terrains.Count);
        for (int i = 1; i <= 7; i++)
        {
            if (i == 2) { RVectorZ = -1500; }
            if (i == 3) { RVectorZ = -2250; }
            if (i == 4) { RVectorZ = -3000; }
            if (i == 5) { RVectorX = 1500; }
            if (i == 6) { RVectorX = 750; }
            if (i == 7) { RVectorX = 0; }
            Instantiate(Terrains[RandomTerrain], new Vector3(RVectorX, 0, RVectorZ), Quaternion.Euler(0, 0, 0));
        }

    }


    private void Ring4()
    {

        int RVectorX, RVectorZ;

        RVectorX = 3000;
        RVectorZ = 3000;

        int RandomTerrain = Random.Range(0, Terrains.Count);
        for (int i = 1; i <= 36; i++)
        {
            if (i == 2) { RVectorZ = 2250; }
            if (i == 3) { RVectorZ = 1500; }
            if (i == 4) { RVectorZ = 750; }
            if (i == 5) { RVectorZ = 0; }
            if (i == 6) { RVectorZ = -750; }
            if (i == 7) { RVectorZ = -1500; }
            if (i == 8) { RVectorZ = -2250; }
            if (i == 9) { RVectorZ = -3000; }
            if (i == 10) { RVectorZ = -3750; }

            if (i == 11) { RVectorX = 2250; }
            if (i == 12) { RVectorX = 1500; }
            if (i == 13) { RVectorX = 750; }
            if (i == 14) { RVectorX = 0; }
            if (i == 15) { RVectorX = -750; }
            if (i == 16) { RVectorX = -1500; }
            if (i == 17) { RVectorX = -2250; }
            if (i == 18) { RVectorX = -3000; }
            if (i == 19) { RVectorX = -3750; }

            if (i == 20) { RVectorZ = -3000; }
            if (i == 21) { RVectorZ = -2250; }
            if (i == 22) { RVectorZ = -1500; }
            if (i == 23) { RVectorZ = -750; }
            if (i == 24) { RVectorZ = 0; }
            if (i == 25) { RVectorZ = 750; }
            if (i == 26) { RVectorZ = 1500; }
            if (i == 27) { RVectorZ = 2250; }
            if (i == 28) { RVectorZ = 3000; }

            if (i == 29) { RVectorX = -3000; }
            if (i == 30) { RVectorX = -2250; }
            if (i == 31) { RVectorX = -1500; }
            if (i == 32) { RVectorX = -750; }
            if (i == 33) { RVectorX = 0; }
            if (i == 34) { RVectorX = 750; }
            if (i == 35) { RVectorX = 1500; }
            if (i == 36) { RVectorX = 2250; }

            Instantiate(Terrains[RandomTerrain], new Vector3(RVectorX, 0, RVectorZ), Quaternion.Euler(0, 0, 0));
        }

    }


    private void LoadList() {


        Terrains = new List<GameObject>(Resources.LoadAll<GameObject>("TerrainSpawns"));



    }



}



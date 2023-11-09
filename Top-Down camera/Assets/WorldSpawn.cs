using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class WorldSpawn : MonoBehaviour
{
  /*  public GameObject BlackTerrain;
    public GameObject BlueTerrain;
    public GameObject BrownTerrain;
    public GameObject RedTerrain;
    public GameObject YellowTerrain;
    public GameObject WhiteTerrain;
    public GameObject GreenTerrain;*/

    //private bool canSpawn = true;

    private int CVectorX, CVectorY, CVectorZ;
    // Start is called before the first frame update

    private static List<GameObject> CenterRing;

    void Start()
    {
        LoadList();
        Instantiate(CenterRing[0], new Vector3(-250, 0, -250), Quaternion.Euler(0, 0, 0));

    }

    // Update is called once per frame
    void Update()
    {

    }


    private void Center()
    {



    }

    private void LoadList() {


        CenterRing = new List<GameObject>(Resources.LoadAll<GameObject>("TerrainSpawns"));



    }



}



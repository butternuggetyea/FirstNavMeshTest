using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemy;
    Transform PlayerPos;

    TerrainPosition terrainPosition;

    GameObject game;

    private bool EnoughDead = false;
    private bool weaponfound = false;

    int EnemysKilled = 0;

    middleman Middleman;
    // Start is called before the first frame update
    void Start()
    {
        Middleman = FindFirstObjectByType<middleman>();
        terrainPosition = FindAnyObjectByType<TerrainPosition>();
        PlayerPos = GameObject.Find("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (weaponfound == true) 
        {
            EnemysKilled = middleman.EnemysKilled;
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            
           
            StartCoroutine(SpawnEnemy());

        }




    }

    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {

            StopAllCoroutines();

        }
    }

    IEnumerator SpawnEnemy()
    {


        for (int i = 0; i < 1; i++)
        {
            Debug.Log(EnemysKilled);
            if (EnemysKilled >= 100) {
                i++;
            }
            
            i--;

            int RandomNum = Random.Range(-25, 25);
            int NumX = RandomNum;
            int NumZ = RandomNum;
            Debug.Log(NumX + PlayerPos.position.x);
  
            if (PlayerPos.position.x + NumX >= terrainPosition.PosX )
            {
                if (PlayerPos.position.x + NumX <= terrainPosition.PosX + 750) 
                {
                    if (PlayerPos.position.z + NumZ >= terrainPosition.PosZ) 
                    {
                        if (PlayerPos.position.z + NumZ <= terrainPosition.PosZ + 750)
                        {
                     
                          Debug.Log("spawned");
                                  
                          Instantiate(enemy, new Vector3(PlayerPos.position.x + NumX, 10, PlayerPos.position.z + NumZ), Quaternion.Euler(0, 0, 0));
                                
                            
                        }
                    }
                }
               
            }
            yield return new WaitForSeconds(5f);

        }


    }

}

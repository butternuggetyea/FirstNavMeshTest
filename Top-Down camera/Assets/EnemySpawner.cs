using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemy;
    Transform PlayerPos;

    TerrainPosition terrainPosition;

    // Start is called before the first frame update
    void Start()
    {
        terrainPosition = FindAnyObjectByType<TerrainPosition>();
        PlayerPos = GameObject.Find("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log(PlayerPos.position.x);
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
        int EnemysSpawned = 0;
        for (int i = 0; i < 100; i++)
        {
            
            i--;
            int RandomNum = Random.Range(-25, 25);
            int NumX = RandomNum;
            int NumZ = RandomNum;

  
            if (PlayerPos.position.x + NumX >= terrainPosition.PosX )
            {
                if (PlayerPos.position.x + NumX <= terrainPosition.PosX + 750) 
                {
                    if (PlayerPos.position.z + NumZ >= terrainPosition.PosZ) 
                    {
                        if (PlayerPos.position.z + NumZ <= terrainPosition.PosZ + 750)
                        {
                            Debug.Log("spawned");
                            i++; ;
                            Instantiate(enemy, new Vector3(PlayerPos.position.x + NumX, 2, PlayerPos.position.z + NumZ), Quaternion.Euler(0, 0, 0));
                        }
                    }
                }
               
            }
            yield return new WaitForSeconds(5f);

        }


    }

}

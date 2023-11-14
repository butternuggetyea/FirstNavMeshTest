using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraRotation : MonoBehaviour
{
    Transform PlayerPos;

    private static int Yrotate;

    private float Playerx, Playery, Playerz;

    private void Awake()
    {
        PlayerPos = GameObject.Find("Player").transform;

    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)) 
        {
            Yrotate += 20;
            Playerx = PlayerPos.gameObject.transform.position.x;
            Playery = PlayerPos.gameObject.transform.position.y;
            Playerz = PlayerPos.gameObject.transform.position.z;
            Debug.Log(Playerx);
            Debug.Log(Playery);
            Debug.Log(Playerz);
            Quaternion.Euler(0, Yrotate, 0);

        }
                if (Input.GetKeyDown(KeyCode.Q)) 
        {
            Playerx = PlayerPos.gameObject.transform.position.x;
            Playery = PlayerPos.gameObject.transform.position.y;
            Playerz = PlayerPos.gameObject.transform.position.z;
            Debug.Log(Playerx);
            Debug.Log(Playery);
            Debug.Log(Playerz);
            transform.Rotate(0,-20,0,Space.Self);
        
        }

    }
}

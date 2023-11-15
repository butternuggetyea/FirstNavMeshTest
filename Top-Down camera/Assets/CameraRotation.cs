using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CameraRotation : MonoBehaviour
{
    public Transform PlayerPos;

    private static float Yrotate = 0;

    private float Playerx, Playery, Playerz;

    private void Awake()
    {
        

    }


    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.E)) 
        {
            Yrotate -= 0.2f;

         

        }

        if (Input.GetKeyUp(KeyCode.E))
        {
            Yrotate = 0;



        }

        if (Input.GetKeyDown(KeyCode.Q)) 
        {
            Yrotate += 0.2f;
   

        }

        if (Input.GetKeyUp(KeyCode.Q))
        {
            Yrotate = 0;



        }
        transform.RotateAround(PlayerPos.position, Vector3.up, Yrotate);
    }
}

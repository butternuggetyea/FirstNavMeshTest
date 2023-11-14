using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLookAt : MonoBehaviour
{
        public float SenseX;
    public float SenseY;

    public Transform orientation;

    float xRotation;
    float yRotation;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * SenseX;
        float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * SenseY;

        yRotation -= mouseX;

    

      

        transform.rotation = Quaternion.Euler(0, yRotation, 0);
       
    }
}

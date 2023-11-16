using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLookAt : MonoBehaviour
{
        public float SenseX;
    public float SenseY;

    public Transform orientation;
    public Transform playerObj;

    float xRotation;
    float yRotation;

    public Camera cam1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePosition = Input.mousePosition;

        // Cast a ray from the camera to the mouse position
        Ray ray = Camera.main.ScreenPointToRay(mousePosition);

        // Create a plane at the object's position (you can adjust this if needed)
        Plane plane = new Plane(Vector3.up, transform.position);

        float hitDistance;

        // Check if the ray intersects the plane
        if (plane.Raycast(ray, out hitDistance))
        {
            // Get the point on the plane where the ray intersects
            Vector3 targetPoint = ray.GetPoint(hitDistance);

            // Calculate the direction to the target point
            Vector3 directionToTarget = targetPoint - transform.position;

            // Ignore the y component if you want to rotate only around the Y-axis
            directionToTarget.y = 0;

            // Create a rotation to face the target direction
            Quaternion targetRotation = Quaternion.LookRotation(directionToTarget);

            // Smoothly rotate towards the target rotation
            float rotationSpeed = 5f; // Adjust this value for desired rotation speed
       
                transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime*10);
            
        }








        //gameObject.transform.forward
        Quaternion rotation = transform.rotation;

        // Get the original forward vector (local forward)
        Vector3 originalForward = Vector3.forward;

        // Rotate the original forward vector using the current rotation
        Vector3 rotatedForward = rotation * originalForward;

        Vector3 worldRotatedForward = transform.TransformDirection(rotatedForward);
        Debug.DrawRay(transform.position, worldRotatedForward * 3f, Color.green);

    }
}

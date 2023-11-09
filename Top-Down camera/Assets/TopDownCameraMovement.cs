using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownCameraMovement : MonoBehaviour
{
    public float moveSpeed;
    public Transform player;
    public Vector3 offset;
    public float followDistance;
    public Quaternion rotation;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = Vector3.Lerp(transform.position, player.position + offset + -transform.forward * followDistance, moveSpeed * Time.deltaTime);
       
        transform.position = pos;

        transform.rotation = rotation;
    }
}

using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using UnityEditor;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [Header("Movement")]
    private float moveSpeed;
    public float walkSpeed;
    public float sprintSpeed;

    public float groundDrag;

    [Header("Jumping")]
    public float jumpForce;
    public float jumpCooldown;
    public float airMultiplier;
    bool readyToJump;

    [Header("Crouching")]
    public float crouchSpeed;
    public float crouchYScale;
    private float startYScale;



    [Header("Keybinds")]
    public KeyCode jumpKey = KeyCode.Space;
    public KeyCode sprintKey = KeyCode.LeftShift;
    public KeyCode crouchKey = KeyCode.LeftControl;

    [Header("Ground check")]
    public float playerHeight;
    public LayerMask whatIsGround;
    bool grounded;

    public Transform orientation;

    float horizontalInput;
    float verticalInput;

    Vector3 moveDirection;

    Rigidbody rb;

    public MovementState state;

    public enum MovementState {
        
        walking,
        sprinting,
        crouching,
        air
    
    }

    void Start()
    {
        readyToJump = true;
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;

        startYScale = transform.localScale.y;
    }
    private void Update()
    {
        // checks for ground
        grounded = Physics.Raycast(transform.position, Vector3.down, playerHeight * 0.5f + 0.2f, whatIsGround);

        MyInput();
        speedControl();
        StateHandler();

        // do the drag
        if (grounded)
        {
            rb.drag = groundDrag;
        }
        else {
            rb.drag = 0;
        }
    }

    private void FixedUpdate()
    {
        MovePlayer();
    }
    private void MyInput()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");

        if (Input.GetKey(jumpKey) && readyToJump == true && grounded == true)
        {

            readyToJump = false;

            Jump();

            Invoke(nameof(ResetJump), jumpCooldown);
        }

        if (Input.GetKeyDown(crouchKey)) {

            transform.localScale = new Vector3(transform.localScale.x, crouchYScale, transform.localScale.z);
            rb.AddForce(Vector3.down * 5f, ForceMode.Impulse);

        }

        if (Input.GetKeyUp(crouchKey)) {

            transform.localScale = new Vector3(transform.localScale.x, startYScale, transform.localScale.z);

        }

    }

    private void StateHandler() {

        if (Input.GetKey(crouchKey)) {

            state = MovementState.crouching;
            moveSpeed = crouchSpeed;

        }

       else if (grounded && Input.GetKey(sprintKey)) {

            state = MovementState.sprinting;
            moveSpeed = sprintSpeed;
        }

        else if (grounded) {

            state = MovementState.walking;
            moveSpeed = walkSpeed;

        }
        else{

            state = MovementState.air;

        }
    
    }

    private void MovePlayer(){
        
        moveDirection = orientation.forward * verticalInput + orientation.right * horizontalInput;

        if (grounded)
        rb.AddForce(moveDirection.normalized * moveSpeed * 10f, ForceMode.Force);
        
        else if (!grounded) 
         rb.AddForce(moveDirection.normalized * moveSpeed * 10f * airMultiplier, ForceMode.Force);
     
    }

    private void speedControl() {

        Vector3 flatVel = new Vector3(rb.velocity.x, 0f, rb.velocity.z);

        if (flatVel.magnitude > moveSpeed) {

            Vector3 limitedVel = flatVel.normalized * moveSpeed;
            rb.velocity = new Vector3(limitedVel.x, rb.velocity.y, limitedVel.z);

        }
    
    }

    private void Jump() {

        rb.velocity = new Vector3(rb.velocity.x, 0f, rb.velocity.z);

        rb.AddForce(transform.up * jumpForce, ForceMode.Impulse);

    }

    private void ResetJump()
    {
        readyToJump = true;
    }

}
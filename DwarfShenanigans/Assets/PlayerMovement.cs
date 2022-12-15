using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;

public class PlayerMovement : NetworkBehaviour
{
    public float moveSpeed;
    public float sprintSpeedIncrease;

    private Rigidbody2D rb;
    private Vector2 moveInput;
    private Animator animator;
    private bool isRunning;
    private bool facingRight = true;

    private void Awake()
    {
        
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }


    void Start() {
        // set camera to its position if owner
        if (IsOwner)  
            Camera.main.GetComponent<SmoothCameraFollow>().setTarget(transform);
    }

    // Update is called once per frame
    void Update()
    {
        if (!IsOwner) return;
        
        moveInput.x = Input.GetAxisRaw("Horizontal");
        moveInput.y = Input.GetAxisRaw("Vertical");
        moveInput.Normalize();
        //flip when going left or right
        if (moveInput.x < 0 && facingRight) {
            Flip();
        }
        else if (moveInput.x > 0 && !facingRight){
            Flip();
        }

        animator.SetBool("isMoving",IsMoving());
        rb.velocity = moveInput * moveSpeed;

        //running check
        if (Input.GetKeyDown(KeyCode.LeftShift)) {
            moveSpeed += sprintSpeedIncrease;
            isRunning = true;
        } 
        else if (Input.GetKeyUp(KeyCode.LeftShift)) {
            moveSpeed -= sprintSpeedIncrease;
            isRunning = false;
        }

        animator.SetBool("isRunning",isRunning && IsMoving());
    }

    bool IsMoving()
    {
        float movement = Mathf.Max(Mathf.Abs(moveInput.x), Mathf.Abs(moveInput.y));
        return (movement > 0);
    }

    void Flip()
    {
        Vector3 currentScale = gameObject.transform.localScale;
        currentScale.x *= -1;
        gameObject.transform.localScale = currentScale;
        facingRight = !facingRight;
    }
}

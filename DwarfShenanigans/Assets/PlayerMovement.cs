using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;
    public float sprintSpeedIncrease;
    private Rigidbody2D rb;
    private Vector2 moveInput;
    private Animator animator;
    private SpriteRenderer sp;
    private bool isRunning;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        sp = GetComponent<SpriteRenderer>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moveInput.x = Input.GetAxisRaw("Horizontal");
        moveInput.y = Input.GetAxisRaw("Vertical");
        moveInput.Normalize();
        if (moveInput.x < 0) {
            sp.flipX = true;
        }
        else if (moveInput.x > 0){
            sp.flipX = false;
        }
        animator.SetBool("isMoving",isMoving());
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

        animator.SetBool("isRunning",isRunning && isMoving());
    }

    bool isMoving()
    {
        float movement = Mathf.Max(Mathf.Abs(moveInput.x), Mathf.Abs(moveInput.y));
        return (movement > 0);
    }

}

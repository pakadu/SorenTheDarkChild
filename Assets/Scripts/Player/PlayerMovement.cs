using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //Movement 
    [SerializeField] private float movementSpeed = 5f;
    Rigidbody2D rb;
    [HideInInspector]
    public float lastHorizontalVector;
    [HideInInspector]
    public float lastVerticalVector;
    [HideInInspector]
    public Vector2 moveDir;
    [HideInInspector]
    public Vector2 lastMovedVector;
    
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        lastMovedVector = new Vector2(1, 0f); //start shooting
    }

    // Update is called once per frame
    void Update()
    {
        InputManagement();
    }

    void FixedUpdate()
    {
        Move();
    }

  void InputManagement()
{
    float moveX = Input.GetAxisRaw("Horizontal");
    float moveY = Input.GetAxisRaw("Vertical");

    moveDir = new Vector2(moveX, moveY).normalized;

    // Update lastMovedVector based on movement direction
    if (moveDir.magnitude != 0)
    {
        lastMovedVector = moveDir;
        lastHorizontalVector = moveDir.x;
        lastVerticalVector = moveDir.y;
    }
}


    void Move()
    {
        rb.velocity = new Vector2(moveDir.x * movementSpeed, moveDir.y * movementSpeed);
    }
}

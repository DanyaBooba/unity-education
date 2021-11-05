using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Transform groundPoint;
    public LayerMask groundLayer;

    private Rigidbody2D rb;

    private float speed = 7f;
    private float jumpForce = 5f;

    private float moveInput;
    private float flipValue;

    private bool isGround;
    private int extraJump;
    private int extraJumpValue = 1;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);

        if(moveInput != 0) flipValue = FlipValue(moveInput);
        transform.eulerAngles = VectorFlip(flipValue);

        isGround = Ground();
        if (isGround)
            extraJump = extraJumpValue;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }

    private void Jump()
    {
        if(extraJump > 0)
        {
            extraJump -= 1;
            rb.velocity = Vector2.up * jumpForce;
        }
    }

    private Vector3 VectorFlip(float count)
    {
        Vector3 vector = new Vector3(0, count, 0);
        return vector;
    }

    private float FlipValue(float count)
    {
        if (count > 0) return 180;
        return 0;
    }

    private Collider2D Ground()
    {
        Collider2D physics = Physics2D.OverlapCircle(groundPoint.position, 0.25f, groundLayer);
        return physics;
    }
}

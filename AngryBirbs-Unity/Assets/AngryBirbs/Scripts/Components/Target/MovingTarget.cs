using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingTarget : MonoBehaviour
{
    [Range( 0, 5 )]
    public float HalfPathDistance = 3;
    [Range( 0, 5 )]
    public float MovementSpeed = 2;
    Vector3 initialPosition;
    Rigidbody2D rb;

    private void Start()
    {
        initialPosition = this.transform.position;
        rb = this.GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        //Debug.Log(initialPosition);
        //Debug.Log(this.transform.position.y);
        //Debug.Log(rb.velocity.magnitude);

        if (this.transform.position.y <= (initialPosition.y + HalfPathDistance) && rb.velocity.y == 0)
        {
            rb.velocity = Vector2.up * MovementSpeed;
        }

        if (this.transform.position.y >= (initialPosition.y + HalfPathDistance) && rb.velocity.y >= MovementSpeed)
        {
            rb.velocity = Vector2.down * MovementSpeed;
        }

        if (this.transform.position.y <= (initialPosition.y - HalfPathDistance) && rb.velocity.y <= -MovementSpeed)
        {
            rb.velocity = Vector2.up * MovementSpeed;
        }
    }

    
}

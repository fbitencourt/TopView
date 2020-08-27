using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float movementSpeed = 5f;
    public Rigidbody2D body;
    public Camera camera;

    Vector2 movement;
    Vector2 mousePosition;
    private void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        mousePosition = camera.ScreenToWorldPoint(Input.mousePosition);
    }

    private void FixedUpdate()
    {
        body.MovePosition(body.position + movement * movementSpeed * Time.fixedDeltaTime);

        //Substrair os dois devolve onde esta olhando
        Vector2 lookDirection = mousePosition - body.position;

        float angle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg - 90f;

        body.rotation = angle;
    }
    //Rigidbody2D body;

    //float horizontal;
    //float vertical;
    //float moveLimiter = 0.7f;

    //public float runSpeed = 20.0f;

    //void Update()
    //{
    //    // Gives a value between -1 and 1
    //    horizontal = Input.GetAxis("Horizontal"); // -1 is left
    //    vertical = Input.GetAxis("Vertical"); // -1 is down
    //}

    //void FixedUpdate()
    //{
    //    if (horizontal != 0 && vertical != 0) // Check for diagonal movement
    //    {
    //        // limit movement speed diagonally, so you move at 70% speed
    //        horizontal *= moveLimiter;
    //        vertical *= moveLimiter;
    //    }

    //    body.velocity = new Vector2(horizontal * runSpeed, vertical * runSpeed);
    //}
}

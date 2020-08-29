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
}

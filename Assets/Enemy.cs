using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D body;

    float horizontalInit;
    float verticalInit;
    float destination;
    float moveLimiter = 0.7f;

    public float runSpeed = 20.0f;
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        horizontalInit = body.position.x;
        verticalInit = body.position.y;
        destination = horizontalInit + 30;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        body.transform.position = Vector2.MoveTowards(body.transform.position, new Vector2(destination, horizontalInit), 100);
    }
}

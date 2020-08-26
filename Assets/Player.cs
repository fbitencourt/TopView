using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D body;

    float horizontal;
    float vertical;
    float moveLimiter = 0.7f;

    float? tamanhoCameraOriginal;
    GameObject personagem;

    public float runSpeed = 20.0f;

    public Camera MainCamera;
    public Grid grid;

    void Start()
    {
        personagem = GameObject.Find("Personagem");
        body = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Gives a value between -1 and 1
        horizontal = Input.GetAxisRaw("Horizontal"); // -1 is left
        vertical = Input.GetAxisRaw("Vertical"); // -1 is down

        if (Input.GetKey(KeyCode.Space))
        {
            var sprint = personagem.GetComponentInChildren<SpriteRenderer>();

            Instantiate(sprint);

            //if (!tamanhoCameraOriginal.HasValue)
            //    tamanhoCameraOriginal = MainCamera.orthographicSize;

            //var size = MainCamera.orthographicSize;

            //if (tamanhoCameraOriginal.HasValue && size == tamanhoCameraOriginal)
            //    MainCamera.orthographicSize = size / 2;

            //else
            //    MainCamera.orthographicSize = tamanhoCameraOriginal.Value;
        }

    }

    void FixedUpdate()
    {
        if (horizontal != 0 && vertical != 0) // Check for diagonal movement
        {
            // limit movement speed diagonally, so you move at 70% speed
            horizontal *= moveLimiter;
            vertical *= moveLimiter;
        }

        body.velocity = new Vector2(horizontal * runSpeed, vertical * runSpeed);
    }
}

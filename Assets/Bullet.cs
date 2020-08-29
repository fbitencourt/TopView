using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject hitEffect;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 4)
        {
            var collider = GetComponent<Collider2D>();
            Physics2D.IgnoreCollision(collision.collider, collider, true);
            return;
        }

        if (!collision.collider.ToString().Contains("Bullet"))
        { 
            GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
            Destroy(effect, 0.5f);
            Destroy(gameObject);
        }

    }
}

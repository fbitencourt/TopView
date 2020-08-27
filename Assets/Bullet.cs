using UnityEngine;

public class Bullet : MonoBehaviour
{

    public GameObject hitEffect;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!collision.collider.ToString().Contains("Bullet"))
        {
            GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
            Destroy(effect, 0.5f);
            Destroy(gameObject);
        }

    }
}

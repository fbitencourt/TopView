using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bullet;

    public float bulletForce = 150f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        GameObject bulletFired = Instantiate(bullet, firePoint.position, firePoint.rotation);
        bulletFired.layer = 1;
        Rigidbody2D bulletBody = bulletFired.GetComponent<Rigidbody2D>();
        var sprite = bulletFired.GetComponent<SpriteRenderer>();
        sprite.sortingOrder = 2;
        bulletBody.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
    }
}

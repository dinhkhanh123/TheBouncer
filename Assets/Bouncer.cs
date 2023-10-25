using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bouncer : MonoBehaviour
{
    int health = 100;
    public Slider slider; // S?c kh?e ban ??u c?a Bouncer
    private int bounces = 0;  // S? l?n n?y
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        // X? lý s? ki?n b?m phím Space
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Ki?m tra va ch?m v?i c?nh màn hình
        if (collision.gameObject.CompareTag("MainCamera"))
        {
            bounces++;
            // Khi ??i t??ng ?ã n?y ?? l?n (ví d? 10 l?n), phá h?y nó
            if (bounces >= 10)
            {
                Destroy(gameObject);
            }
        }
        else
        {
            // N?u không ph?i c?nh màn hình, gi?m s?c kh?e ?i 10 ??n v?
            health -= 10;
            slider.value = health;
            if (health <= 0)
            {
                // Khi s?c kh?e d??i ho?c b?ng 0, phá h?y ??i t??ng
                Destroy(gameObject);
            }
        }
    }

    private void Jump()
    {
        // Thêm l?c n?y lên khi b?m Space
        rb.AddForce(Vector2.up * 500);  // ?i?u ch?nh l?c n?y theo nhu c?u
    }
}

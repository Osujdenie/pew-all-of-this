using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBullet : MonoBehaviour
{
    public float speed;

    void FixedUpdate()
    {
        transform.Translate(Vector2.up * speed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Circles")
            Destroy(gameObject);

        if (collision.gameObject.tag == "Surfaces")
            Destroy(gameObject);
    }
}

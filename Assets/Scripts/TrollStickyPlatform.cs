using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrollStickyPlatform : MonoBehaviour
{
    private float speed = 10f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            collision.gameObject.transform.SetParent(transform);
            transform.Rotate(0, 0, 360 * speed * Time.deltaTime);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            collision.gameObject.transform.SetParent(null);
            transform.Rotate(0, 0, 360 * speed * Time.deltaTime);
        }
    }
}

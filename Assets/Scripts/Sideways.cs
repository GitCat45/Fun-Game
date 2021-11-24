using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sideways : MonoBehaviour
{
    private float launch = 50f;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            //collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * launch, ForceMode2D.Impulse); ;

            Debug.Log("sdaddadkfjk");

        }
    }
}

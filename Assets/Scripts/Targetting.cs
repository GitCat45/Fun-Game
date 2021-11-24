using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody2D))]
public class Targetting : MonoBehaviour
{
    public Transform target;

    public float speed = 3f;

    public float rotateSpeed = 200f;

    private Rigidbody2D rb;

    // Start is called before the fir t frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }   

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 diretion = (Vector2)target.position - rb.position;

        diretion.Normalize();

        float rotateAmmount = Vector3.Cross(diretion, transform.up).z;

        rb.angularVelocity = -rotateAmmount * rotateSpeed;

        rb.velocity = transform.up * speed; 

        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }
}

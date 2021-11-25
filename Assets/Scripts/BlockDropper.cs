using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockDropper : MonoBehaviour
{

    private Rigidbody2D rb;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name.Equals ("Player"))
        {
            //uncomment the below for debug.

            //Debug.Log("jhfgjagökjalgöjahgkdkjgfaglkflkakanvanv");

            rb.isKinematic = false;
            rb.gravityScale = 20;

        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockremovingThig : MonoBehaviour
{
    private SpriteRenderer sr;

    private void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            //Debug.Log("testtesttestestest");
            sr.enabled = false;
        }
    }
    
}

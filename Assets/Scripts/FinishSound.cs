using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishSound : MonoBehaviour
{
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        audioSource.Play();
        Completelevel();
    }

    private void Completelevel()
    {

    }
}

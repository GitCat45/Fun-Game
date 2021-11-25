using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LauncherSound : MonoBehaviour
{
    [SerializeField] private AudioSource playerLaunchSound;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            playerLaunchSound.Play();
        }
    }
}

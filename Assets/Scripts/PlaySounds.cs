using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySounds : MonoBehaviour
{
    private AudioSource audioSource;
    public AudioClip audioClip;
    public AudioClip jumpSound;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Jump"))
            audioSource.PlayOneShot(jumpSound);
        else
            audioSource.PlayOneShot(audioClip);
    }
}

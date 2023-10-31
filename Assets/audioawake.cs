using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioawake : MonoBehaviour
{
    private static audioawake instance;

    void Awake()
    {
        

        audioSource = GetComponent<AudioSource>();
        audioSource.Play();
    }

    private AudioSource audioSource;

}

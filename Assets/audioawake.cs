using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioawake : MonoBehaviour
{
    private static audioawake instance;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            // 如果实例已存在，则销毁新的实例
            Destroy(gameObject);
        }

        audioSource = GetComponent<AudioSource>();
        audioSource.Play();
    }

    private AudioSource audioSource;

}

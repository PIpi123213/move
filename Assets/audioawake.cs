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
            // ���ʵ���Ѵ��ڣ��������µ�ʵ��
            Destroy(gameObject);
        }

        audioSource = GetComponent<AudioSource>();
        audioSource.Play();
    }

    private AudioSource audioSource;

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class collision : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioClip collisionSound; // ��Ч�ļ�
    private AudioSource audioSource;
    
    
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ground"))
        {
            playermanager.isGround = true;

            if (soundeffect.isFirst)
            {
                audioSource.clip = collisionSound;

                audioSource.Play();

            }
            else
            {
                
                soundeffect.isFirst = true;
            }
        }
       
           
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Ground"))
        {
            playermanager.isGround = false;


        }


    }


    }


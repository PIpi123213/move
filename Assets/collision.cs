using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class collision : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioClip collisionSound; // ÒôÐ§ÎÄ¼þ
    private AudioSource audioSource;
    
    int a = 0;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ground"))
        {
            
       
            if (soundeffect.isGround)
            {
                audioSource.clip = collisionSound;

                audioSource.Play();

            }
            else
            {
                Debug.Log("1");
                soundeffect.isGround = true;
            }
        }
       
           
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Ground"))
        {
        }
    }




}


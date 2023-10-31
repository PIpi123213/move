using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitZone : MonoBehaviour
{
    public string sceneToLoad; // ��Unity�༭����ָ��Ҫ���صĳ�������

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // ������ķ�����һ��"Player"��ǩ
        {
          
            // ����ָ���ĳ���
            SceneManager.LoadScene(sceneToLoad);
            GameManager.countScene++;

        }
    }
}

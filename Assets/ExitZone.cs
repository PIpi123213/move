using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitZone : MonoBehaviour
{
    public string sceneToLoad; // 在Unity编辑器中指定要加载的场景名称

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // 假设你的方块有一个"Player"标签
        {
          
            // 加载指定的场景
            SceneManager.LoadScene(sceneToLoad);
            GameManager.countScene++;

        }
    }
}

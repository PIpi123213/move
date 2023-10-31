using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : MonosingletonTemp<SoundManager>
{
    // Start is called before the first frame update
    private static GameManager instance;
    public static int countScene = 0;
   /* void Awake()
    {
        if (instance == null)
        {
            instance = this ;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            // ���ʵ���Ѵ��ڣ��������µ�ʵ��
            Destroy(gameObject);
        }


    }*/

}

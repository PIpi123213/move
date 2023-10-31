using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonosingletonTemp<T> : MonoBehaviour where T : MonosingletonTemp<T>
{
    // Start is called before the first frame update
    private static T _instance;
    public static T Instance
    {

        get
        {
            new GameObject(typeof(T).Name).AddComponent<T>();
            return _instance;
        }
    }
    void Awake()
    {
        if (_instance == null)
        {
            _instance = this as T;
          
        }
        else
        {
            // 如果实例已存在，则销毁新的实例
            Destroy(gameObject);
        }
        
        DontDestroyOnLoad(gameObject);

    }

















}

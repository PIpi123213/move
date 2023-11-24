using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static GameManager instance;
    public static int countScene = 0;
    public Inventory inventory;
    public PickUp OnionPoint1;
    public PickUp SteakPoint1;
    public PickUp OnionPoint2;
    public PickUp SteakPoint2;
    
    private bool awakeExecuted = false;
    public void OnEnable()
    {
        CheckAndSpawnItems();
        SceneManager.sceneLoaded += OnSceneLoaded;
    }
    void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }
    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        // 在每次场景加载完成后执行的逻辑
        // 调用生成物品的方法
        if (OnionPoint1.sceneName != SceneManager.GetActiveScene().name)
        {
            OnionPoint1.isGenerate = false;
        }
        if (OnionPoint2.sceneName != SceneManager.GetActiveScene().name)
        {
            OnionPoint2.isGenerate = false;
        }
        if (SteakPoint1.sceneName != SceneManager.GetActiveScene().name)
        {
            SteakPoint1.isGenerate = false;
        }
        if (SteakPoint2.sceneName != SceneManager.GetActiveScene().name)
        {
            SteakPoint2.isGenerate = false;
        }
       
        CheckAndSpawnItems();
    }
    void Awake()
    {
        
        
       
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
            OnionPoint1.isGenerate = false;
            OnionPoint2.isGenerate = false;
            SteakPoint1.isGenerate = false;
            SteakPoint2.isGenerate = false;


            OnionPoint1.isPickedUp = false;
            SteakPoint1.isPickedUp = false;
            OnionPoint1.sceneName = "SampleScene";
            SteakPoint1.sceneName = "SampleScene";


            OnionPoint1.spawnPoint = OnionPoint1.initalPosition.position;
            SteakPoint1.spawnPoint = SteakPoint1.initalPosition.position;

            OnionPoint2.isPickedUp = false;
            SteakPoint2.isPickedUp = false;
            OnionPoint2.sceneName = "1";
            SteakPoint2.sceneName = "1";
            OnionPoint2.spawnPoint = OnionPoint2.initalPosition.position;
            SteakPoint2.spawnPoint = SteakPoint2.initalPosition.position;
        }
        else
        {

            Destroy(gameObject);
        }
        // 从PlayerPrefs中获取标志的值
        /*PlayerPrefs.SetInt("HasGeneratedItems", 0);
        PlayerPrefs.Save();
        hasGeneratedItems = PlayerPrefs.GetInt("HasGeneratedItems", 0) == 1;*/
        

        // 在 Awake 中设置 isPickedUp 的初始值
        // Debug.Log("PlayerPrefs HasGeneratedItems: " + PlayerPrefs.GetInt("HasGeneratedItems", 0));
        



    }
   
    private void Start()
    {

        /*OnionPoint1.spawnPoint = OnionPoint1.initalPosition.position;
        SteakPoint1.spawnPoint = SteakPoint1.initalPosition.position;*/
        inventory.itemList.Clear();
        InventoryManager.RefreshItem();
        InventoryManager.ClearItem();
        
        //
        //CheckAndSpawnItems();
        SceneManager.sceneLoaded += OnSceneLoaded;
        

        //Debug.Log("countScene: " + countScene);
        //Debug.Log("Current Scene Index: " + SceneManager.GetActiveScene().buildIndex);

    }
    public void CheckAndSpawnItems()
    {
       


        //Debug.Log("Generating items...");
       
            if (OnionPoint1 != null&&!OnionPoint1.isGenerate)
            {
                if (!OnionPoint1.isPickedUp && OnionPoint1.sceneName == SceneManager.GetActiveScene().name)
                {
                    Instantiate(OnionPoint1.thisObject, OnionPoint1.spawnPoint, Quaternion.identity);
                //Debug.Log("Onion generated");
                OnionPoint1.isGenerate = true;
            }
            }

            if (SteakPoint1 != null && !SteakPoint1.isGenerate)
            {
                if (!SteakPoint1.isPickedUp && SteakPoint1.sceneName == SceneManager.GetActiveScene().name)
                {
                    Instantiate(SteakPoint1.thisObject, SteakPoint1.spawnPoint, Quaternion.identity);
                // Debug.Log("Steak generated");
                SteakPoint1.isGenerate = true;
            }
            }
            
        

        
            
            if (OnionPoint2 != null&&!OnionPoint2.isGenerate)
            {
                if (!OnionPoint2.isPickedUp && OnionPoint2.sceneName == SceneManager.GetActiveScene().name)
                {
                    Instantiate(OnionPoint2.thisObject, OnionPoint2.spawnPoint, Quaternion.identity);
                //Debug.Log("Onion generated");
                OnionPoint2.isGenerate = true;
            }
            }

            if (SteakPoint2 != null && !SteakPoint2.isGenerate)
            {
                if (!SteakPoint2.isPickedUp && SteakPoint2.sceneName == SceneManager.GetActiveScene().name)
                {
                    Instantiate(SteakPoint2.thisObject, SteakPoint2.spawnPoint, Quaternion.identity);
                // Debug.Log("Steak generated");
                SteakPoint2.isGenerate=true;
                }
            }
            






           /* hasGeneratedItems = true;
            countScene = SceneManager.GetActiveScene().buildIndex;
            PlayerPrefs.SetInt("HasGeneratedItems", hasGeneratedItems ? 1 : 0);
            PlayerPrefs.Save();*/
        
    }
}



    /* void Awake()
     {
         


     }*/



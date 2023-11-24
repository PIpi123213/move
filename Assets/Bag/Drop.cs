using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Drop : MonoBehaviour
{
    // Start is called before the first frame update



    private GameObject itemPrefab;  // 物品的预制体

    public GameObject playerTransform;  // 玩家的Transform


    public Button button;
    public PickUp Point;


    void Start()
    {
        // 找到名字为 "drop" 的按钮
        slot slotComponent = GetComponent<slot>();
        // 添加点击事件监听器
        button.onClick.AddListener(SpawnItem);
        itemPrefab = slotComponent.slotItem.thisObject;
        playerTransform = GameObject.Find("Player");
        /*Point = ScriptableObject.CreateInstance<PickUp>();
        Point.slotList = new List<slotInfo>();
    }*/

        // 按钮点击时生成物品
        void SpawnItem()
        {
            slot slotComponent = GetComponent<slot>();
            // 在玩家附近生成物品
            Vector3 spawnPosition = playerTransform.transform.position + new Vector3(2f, 0f, 0f);  // 你可以调整生成位置
            GameObject TempItem = Instantiate(itemPrefab, spawnPosition, Quaternion.identity);
            slotComponent.slotItem.Point.isPickedUp = false;
            slotComponent.slotItem.Point.spawnPoint = spawnPosition;
            slotComponent.spawnPoint = spawnPosition;
            slotComponent.isPickedUp = false;
            slotInfo spawnedSlotInfo = TempItem.GetComponent<slotInfo>();
            itemOnWorld itemOnWorldComponent = TempItem.GetComponent<itemOnWorld>();



            spawnedSlotInfo.isPickedUp = false;
            spawnedSlotInfo.spawnPoint = spawnPosition;

            slotComponent.slotItem.Point.sceneName = SceneManager.GetActiveScene().name;



            if (spawnedSlotInfo == null)
            {
                Debug.LogError("spawnedSlotInfo is null in itemOnWorldComponent.");
            }

            

            if (itemOnWorldComponent.Point != null)
            {
                //Debug.Log("Adding spawnedSlotInfo to slotList.");
                itemOnWorldComponent.Point.slotList.Add(spawnedSlotInfo);

            }
            else
            {
                Debug.LogError("Point is null in itemOnWorldComponent.");
            }
            //Debug.Log("spawnedSlotInfo type: " + spawnedSlotInfo.GetType());
            //Debug.Log("slotList type: " + itemOnWorldComponent.Point.slotList.GetType());
        }
    }
}

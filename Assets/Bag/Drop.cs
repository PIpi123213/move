using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Drop : MonoBehaviour
{
    // Start is called before the first frame update



    private GameObject itemPrefab;  // ��Ʒ��Ԥ����

    public GameObject playerTransform;  // ��ҵ�Transform


    public Button button;
    public PickUp Point;


    void Start()
    {
        // �ҵ�����Ϊ "drop" �İ�ť
        slot slotComponent = GetComponent<slot>();
        // ��ӵ���¼�������
        button.onClick.AddListener(SpawnItem);
        itemPrefab = slotComponent.slotItem.thisObject;
        playerTransform = GameObject.Find("Player");
        /*Point = ScriptableObject.CreateInstance<PickUp>();
        Point.slotList = new List<slotInfo>();
    }*/

        // ��ť���ʱ������Ʒ
        void SpawnItem()
        {
            slot slotComponent = GetComponent<slot>();
            // ����Ҹ���������Ʒ
            Vector3 spawnPosition = playerTransform.transform.position + new Vector3(2f, 0f, 0f);  // ����Ե�������λ��
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

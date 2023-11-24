using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class InventoryManager : MonoBehaviour
{
    static InventoryManager instance;
    public Inventory mybag;
    public GameObject slotGrid;
    public slot slotPrefab;
    //public TextMeshProUGUI itemInfo;
    
    void Awake()
    {
        if (instance != null)
        {
            Destroy(this);
            
        }
        else
        {
            instance = this;
        }
    }
   
    private void OnEnable()
    {
        RefreshItem();
    }
    public static void CreateNewItem(Item item,slotInfo slotInfo=null)
    {

        slot newItem = Instantiate(instance.slotPrefab, instance.slotGrid.transform.position, Quaternion.identity);
        newItem.gameObject.transform.SetParent(instance.slotGrid.transform);
        newItem.slotItem = item;
        newItem.slotImage.sprite = item.itemImage;
        //GameObject TempItem = Instantiate(newItem, spawnPosition, Quaternion.identity);
        //slotInfo spawnedSlotInfo = newItem.GetComponent<slotInfo>();
        //newItem.slotNum.text = item.itemHeld.ToString();
        //newItem.spawnPoint = slotInfo.spawnPoint;
        //newItem.isPickedUp = slotInfo.isPickedUp;


    }
    public static void RefreshItem()
    {
        /*for(int i= 0; i < instance.slotGrid.transform.childCount; i++)
        {
            if(instance.slotGrid.transform.childCount == 0)
            {
                break;
            }
            else 
            { 
                Destroy(instance.slotGrid.transform.GetChild(i).gameObject);
            }
            
        }*/

        for (int i = 0; i < instance.mybag.itemList.Count; i++)
        {
            
            CreateNewItem(instance.mybag.itemList[i]);



        }


    }
    public static void ClearItem()
    {
        for (int i = 0; i < instance.slotGrid.transform.childCount; i++)
        {
            if (instance.slotGrid.transform.childCount == 0)
            {
                break;
            }
            else
            {
                Destroy(instance.slotGrid.transform.GetChild(i).gameObject);
            }

        }
       


    }








}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class itemOnWorld : MonoBehaviour
{
    public Item thisItem;
    public Inventory playerInventory;
    // Start is called before the first frame update
    public PickUp Point;
    public slotInfo itemInfo;


    void Start()
    {
     
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            AddNewItem();
            Destroy(gameObject);
            Point.isPickedUp = true;


        }



    }
    

    public void AddNewItem()
    {
        playerInventory.itemList.Add(thisItem);
        //InventoryManager.CreateNewItem(thisItem);
        /*if (!playerInventory.itemList.Contains(thisItem))
        {
            playerInventory.itemList.Add(thisItem);
        }
        else
        {
            thisItem.itemHeld += 1;
        }*/
        //InventoryManager.RefreshItem();
        
        InventoryManager.CreateNewItem(thisItem,itemInfo);



    }
}

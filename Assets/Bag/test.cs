using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    
    // Start is called before the first frame update
    public PickUp test1;
    public slotInfo b;
    private slotInfo a;
    public Inventory inventory;
    public Item c;
    void Start()
    {

       
        
        inventory.itemList.Add(c);
        
        test1.slotList.Add(b);
        Debug.Log(test1.slotList[0]);
        Debug.Log("SlotInfo details: " +
             "isPickedUp: " + test1.slotList[0].isPickedUp +
             ", spawnPoint: " + test1.slotList[0].spawnPoint);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

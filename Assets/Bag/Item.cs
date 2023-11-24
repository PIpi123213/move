using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Item",menuName = "Inventory/New Item")]

public class Item : ScriptableObject
{
    // Start is called before the first frame update
    public string itemName;
    public Sprite itemImage;
    public int itemHeld;
    [TextArea]
    public string itemText;
    public GameObject thisObject;
    public PickUp Point;

    public bool isPick;
    //Transform thisobject = transform;
    
}

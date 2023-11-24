using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
[CreateAssetMenu(fileName = "PickupData", menuName = "Custom/PickupData")]
public class PickUp : ScriptableObject
{
    public  Vector3 spawnPoint;
    public  bool isPickedUp;
    public GameObject thisObject;
    public Transform initalPosition;
    public bool isGenerate=false;
    public List<slotInfo> slotList = new List<slotInfo>();
    public string sceneName;

    // 在创建 PickUp 数据时，默认场景名为空
    private void OnEnable()
    {
        sceneName = "";
    }


}

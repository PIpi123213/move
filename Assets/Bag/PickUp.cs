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

    // �ڴ��� PickUp ����ʱ��Ĭ�ϳ�����Ϊ��
    private void OnEnable()
    {
        sceneName = "";
    }


}

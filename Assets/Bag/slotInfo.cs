using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slotInfo : MonoBehaviour
{
    public bool isPickedUp;
    public Vector3 spawnPoint;
    public override string ToString()
    {
        return $"slotInfo: isPickedUp = {isPickedUp}, spawnPoint = {spawnPoint}";
    }
}

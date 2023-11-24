using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dropuse : MonoBehaviour
{
    // Start is called before the first frame update
    public Toggle toggle;
    public GameObject targerObject;
    void Start()
    {
        toggle.onValueChanged.AddListener(ToggleClick);
    }

    // Update is called once per frame
    void ToggleClick(bool isOn)
    {
        targerObject.SetActive(isOn);

    }
}

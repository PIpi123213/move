using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bag : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject myBag;
    bool isOpen;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        OpenMyBag();
    }
    void OpenMyBag()
    {
        if(Input.GetKeyUp(KeyCode.B)) { 
        isOpen = !isOpen;
        myBag.SetActive(isOpen);
        
        
        
        
        
        }



    }
}

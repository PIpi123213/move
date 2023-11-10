using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermanager : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool isGround = true;
    public static string A;
    public Animator animator;
    void Start()
    {
        isGround = true;
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetBool("IsIdle", isGround);

        if (isGround)
        {
            A = "IsIdle";


        }
        else
        {
            A = "IsRooling";
        }
        
           


        








    }
}

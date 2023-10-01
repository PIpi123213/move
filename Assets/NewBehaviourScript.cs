using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    public float rollForce = 5f;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // 计算旋转力
        Vector3 rollTorque = new Vector3(verticalInput, 0f, -horizontalInput) * rollForce;

        // 施加旋转力到Cube的Rigidbody
        rb.AddTorque(rollTorque);
    }
}

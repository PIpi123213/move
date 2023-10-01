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

        // ������ת��
        Vector3 rollTorque = new Vector3(verticalInput, 0f, -horizontalInput) * rollForce;

        // ʩ����ת����Cube��Rigidbody
        rb.AddTorque(rollTorque);
    }
}

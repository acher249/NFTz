using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementController : MonoBehaviour
{
    private void Update()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        if (Input.GetKey(KeyCode.A))
            rb.AddForce(Vector3.forward * 10);
        if (Input.GetKey(KeyCode.D))
            rb.AddForce(Vector3.back * 10);
        if (Input.GetKey(KeyCode.W))
            rb.AddForce(Vector3.up * 10);
        if (Input.GetKey(KeyCode.S))
            rb.AddForce(Vector3.down *10);

    }
}

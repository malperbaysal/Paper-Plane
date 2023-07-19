using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneMover : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float rotationSpeed = 50f;

    void Update()
    {
        transform.Translate(Vector3.forward * (Time.deltaTime * moveSpeed));
        
        if (Input.GetKey(KeyCode.W))
        {
            transform.Rotate(Vector3.left * (Time.deltaTime * rotationSpeed));
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Rotate(Vector3.right * (Time.deltaTime * rotationSpeed));
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up * (Time.deltaTime * rotationSpeed));
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.down * (Time.deltaTime * rotationSpeed));
        }
    }
}
 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyTankMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float rotateSpeed = -90;
    public float moveSpeed = 5;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        rb.angularVelocity = Input.GetAxis("Horizontal") * rotateSpeed;
        rb.velocity = transform.up * Input.GetAxis("Vertical") * moveSpeed;
    }
}

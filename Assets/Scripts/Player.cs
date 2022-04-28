using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public InputAction controls;
    public float speed = 200f;
    Rigidbody rb;
    Vector2 moveDirection;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        moveDirection = controls.ReadValue<Vector2>();
    }

    void FixedUpdate(){
        rb.velocity = new Vector3(moveDirection.x * speed * Time.deltaTime, moveDirection.y * speed * Time.deltaTime, 0);
    }

    // OnEnable and OnDisable are needed so the input can work properly
    void OnEnable(){
        controls.Enable();
    }
    void OnDisable(){
        controls.Disable();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Car : MonoBehaviour
{
    [SerializeField] private Rigidbody2D frontTire;
    [SerializeField] private Rigidbody2D backTire;
    [SerializeField] private Rigidbody2D car;
    [SerializeField] private float speed = 150f;
    [SerializeField] private float rotationSpeed = 300f;
   
    public int moveInput;
 
    private void FixedUpdate()
    {
        frontTire.AddTorque(-moveInput * speed * Time.fixedDeltaTime);
        backTire.AddTorque(-moveInput * speed * Time.fixedDeltaTime);
        car.AddTorque(moveInput * rotationSpeed * Time.fixedDeltaTime);
    }

    public float GetInput()
    {
        return moveInput;
    }
}

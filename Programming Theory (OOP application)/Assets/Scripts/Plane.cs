using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane : Vehicle  // INHERITENCE
{
    public float liftSpeed = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Update()
    {
        MoveVehicle();
        SteerVehicle();
    }
    protected override void MoveVehicle() // POLYMORPHISM
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
        
        if (Input.GetKey(KeyCode.Space))
        {
            transform.Rotate(Vector3.left, liftSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.C))
        {
            transform.Rotate(Vector3.right, liftSpeed * Time.deltaTime);
        }
    }

    protected override void SteerVehicle()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.back, Time.deltaTime * turnSpeed * horizontalInput);
    }
}

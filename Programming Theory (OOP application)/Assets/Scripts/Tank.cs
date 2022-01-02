using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank : Vehicle
{
    public Transform tankCannon;
    /*public float yRotationBoundRight = 70f;
    public float yRotationBoundLeft = 290f;
    public float yMiddleBound = 180f;*/

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void LateUpdate()
    {
        RotateCannon();
    }

    void RotateCannon()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit))
        {
            tankCannon.LookAt(new Vector3(hit.point.x, tankCannon.position.y, hit.point.z));
        }
/*
        //Contrain Player Rotation to 70 deg
        if (tankCannon.rotation.eulerAngles.y < yRotationBoundLeft && tankCannon.rotation.eulerAngles.y > yMiddleBound)
        {
            tankCannon.rotation = Quaternion.Euler(tankCannon.rotation.x, yRotationBoundLeft, tankCannon.rotation.z);
        }
        if (tankCannon.rotation.eulerAngles.y > yRotationBoundRight && tankCannon.rotation.eulerAngles.y < yMiddleBound)
        {
            tankCannon.rotation = Quaternion.Euler(tankCannon.rotation.x, yRotationBoundRight, tankCannon.rotation.z);
        }*/
    }
}

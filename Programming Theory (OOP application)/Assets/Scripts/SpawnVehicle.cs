using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnVehicle : MonoBehaviour
{
    [SerializeField] GameObject[] vehicles;
    [SerializeField] int vehicleIndex;

    // Start is called before the first frame update
    void Start()
    {
        vehicleIndex = MainManager.instance.vehicleIndex;
        Spawn(vehicleIndex);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Spawn(int index)
    {
        Vector3 pos = new Vector3(90, 0, 0);
        Vector3 rotation = new Vector3(0, -90, 0);
        Instantiate(vehicles[index], pos, Quaternion.Euler(rotation));
    }
}

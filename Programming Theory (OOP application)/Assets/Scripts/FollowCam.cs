using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCam : MonoBehaviour
{
    GameObject player;
    [SerializeField] Vector3 offset = new Vector3(5f, 3.3f, 0);

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Vehicle");
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}

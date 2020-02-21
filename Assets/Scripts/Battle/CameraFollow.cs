using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    // Start is called before the first frame update
    private Transform player;
    void Start()
    {
        player = GameObject.Find("PlayerObject").transform;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerPos = player.position;
        playerPos.z = transform.position.z;
        transform.position = playerPos;
    }
}

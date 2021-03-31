using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController : MonoBehaviour
{
    public GameObject player;

    private Vector3 offset = new Vector3(0, 0, -10);

    // Update is called once per frame
    void FixedUpdate()
    {
        this.transform.position = player.transform.position + offset; 
    }
}

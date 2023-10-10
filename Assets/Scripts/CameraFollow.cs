using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        GameObject camera = GameObject.FindWithTag("Player");
        transform.position = camera.transform.position + new Vector3(0,0,-10);
    }
}

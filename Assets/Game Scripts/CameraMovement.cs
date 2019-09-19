using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float cameraSpeed = 0.001f;
    void Update()
    {
        transform.position += new Vector3(0f, cameraSpeed, 0f);
    }
}

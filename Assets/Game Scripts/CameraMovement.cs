using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float cameraSpeed = 0.001f;
    public static bool moveCamera = true;

    private void Start() {
        moveCamera = true;
    }

    void Update()
    {

        if (moveCamera) {
                transform.position += new Vector3(0f, cameraSpeed, 0f);
        }

        print(moveCamera);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float cameraSpeed = 0.002f;
    public static bool moveCamera = false;

    private void Start() {
        moveCamera = false;
        Invoke("StartMovingCamera", 3f);
    }

    void Update()
    {

        if (moveCamera) {
                transform.position += new Vector3(0f, cameraSpeed, 0f) * Time.deltaTime;
        }

        //print(moveCamera);
    }

    void StartMovingCamera() {
        moveCamera = true;
    }
}

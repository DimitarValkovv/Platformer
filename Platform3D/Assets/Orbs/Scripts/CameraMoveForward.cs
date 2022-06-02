using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMoveForward : MonoBehaviour
{
    bool cameraIsMoving = false;

    private void Start()
    {
        Application.targetFrameRate = 60;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            cameraIsMoving = true;
        }

        if(cameraIsMoving == true)
        {
            transform.Translate(Vector3.forward * Time.timeScale * 0.05f);
        }
    }

}


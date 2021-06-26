using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    bool cameraIsMoving = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            cameraIsMoving = true;
        }

        if(cameraIsMoving == true)
        {
            transform.Translate(Vector3.left * Time.timeScale * 0.05f);
        }
    }

}


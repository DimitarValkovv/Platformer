using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
 
    void Update()
    {
        transform.Translate(Vector3.left * Time.timeScale * 0.02f);
    }
}

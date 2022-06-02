using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateSky : MonoBehaviour
{
    public float rotateSpeed = 1.2f;


    void Update()
    {
        RenderSettings.skybox.SetFloat("_Rotate", Time.time * rotateSpeed);
    }
}

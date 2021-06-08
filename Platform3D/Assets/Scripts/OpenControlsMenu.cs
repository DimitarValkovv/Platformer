using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenControlsMenu : MonoBehaviour
{

    public GameObject controlsMenu;


     void OnCollisionEnter(Collision collision)
    {
        controlsMenu.SetActive(true);  
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResumScript : MonoBehaviour
{
    public GameObject thePlayer;
    public GameObject controlsMenu;
    public GameObject positionCube;

   public void ResumeMainMenu()
    {
        controlsMenu.SetActive(false);
        thePlayer.transform.position = positionCube.transform.position;
        thePlayer.transform.rotation = positionCube.transform.rotation;
    }
}

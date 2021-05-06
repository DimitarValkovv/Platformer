using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverOnTouch : MonoBehaviour
{
    public GameObject thePlayer;
    public GameObject deathMenu;

     void OnTriggerEnter(Collider target)
    {
        if(target.tag == "Player")
        {
            Time.timeScale = 0f;
            deathMenu.SetActive(true);
        }
    }
}

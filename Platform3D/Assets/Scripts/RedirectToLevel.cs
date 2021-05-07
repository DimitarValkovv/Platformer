using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RedirectToLevel : MonoBehaviour
{
    public static int redirectLevel = 1;

    
    void Update()
    {
        if(redirectLevel == 1)
        {
            SceneManager.LoadScene(redirectLevel);
        }
    }
}

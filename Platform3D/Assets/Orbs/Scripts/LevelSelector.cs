﻿using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelSelector : MonoBehaviour
{

    public void Select(string levelName)
    {
        SceneManager.LoadScene(levelName);
    }
}

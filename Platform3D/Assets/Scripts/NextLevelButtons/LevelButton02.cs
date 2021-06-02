using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelButton02 : MonoBehaviour
{
    public GameObject fadeIn;
    public GameObject gameOverTrig;
    public GameObject theButton;
    public AudioSource gameMusic;
    public void NextLevelOnClick()
    {
        StartCoroutine(LoadNextLevel());
    }

    IEnumerator LoadNextLevel()
    {
        gameMusic.Stop();
        fadeIn.GetComponent<Animator>().Play("FadeIn");
        theButton.SetActive(false);
        Time.timeScale = 1;
        gameOverTrig.SetActive(false);
        yield return new WaitForSecondsRealtime(3.5f);
        SceneManager.LoadScene(2);
        Time.timeScale = 1;
        GlobalScore.currentScore = 0;
    }
}

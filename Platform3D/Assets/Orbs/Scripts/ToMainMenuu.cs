using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToMainMenuu : MonoBehaviour
{
    public GameObject fadeIn;
    public AudioSource gameMusic;
    public GameObject nextLevelButton;
    public GameObject menuButton;
    public GameObject deathCube;

    public void GoingToMainMenu()
    {
        StartCoroutine(ToTheMainMenu());
    }

    IEnumerator ToTheMainMenu()
    {
        gameMusic.Stop();
        nextLevelButton.SetActive(false);
        menuButton.SetActive(false);
        deathCube.SetActive(false);
        fadeIn.GetComponent<Animator>().Play("FadeIn");
        Time.timeScale = 1f;
        yield return new WaitForSeconds(3.5f);
        SceneManager.LoadScene(0);
        GlobalScore.currentScore = 0;
    }
}

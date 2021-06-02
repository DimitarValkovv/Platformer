using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLevel03 : MonoBehaviour
{
    public GameObject fadeIn;
    public AudioSource gameMusic;

   public void RestartLevel()
    {
        StartCoroutine(FadeToRetry());
    }

    IEnumerator FadeToRetry()
    {
        gameMusic.Stop();
        fadeIn.GetComponent<Animator>().Play("FadeIn");
        Time.timeScale = 1f;
        yield return new WaitForSeconds(3.5f);
        SceneManager.LoadScene(3);
    }
}

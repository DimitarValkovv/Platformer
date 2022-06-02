using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverOnTouch : MonoBehaviour
{
    public GameObject thePlayer;
    public GameObject deathMenu;

    public GameObject theScore;
    public GameObject theTime;

    public GameObject fadeIn;
    public AudioSource gameMusic;

     void OnTriggerEnter(Collider target)
    {
        if(target.tag == "Player")
        {
            Time.timeScale = 0f;
            theScore.SetActive(false);
            theTime.SetActive(false);
            deathMenu.SetActive(true);
        }
    }

    public void GoToMainMenu()
    {
        StartCoroutine(ToMainMenu());
    }

    IEnumerator ToMainMenu()
    {
        gameMusic.Stop();
        fadeIn.GetComponent<Animator>().Play("FadeIn");
        Time.timeScale = 1f;
        yield return new WaitForSeconds(3.5f);
        SceneManager.LoadScene(0);
    }
}

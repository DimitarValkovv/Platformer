using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitGame : MonoBehaviour
{
    public GameObject fadeIn;
    public GameObject thePlayer;
    public AudioSource mainMusic;

    void OnCollisionEnter(Collision collision)
    {
        StartCoroutine(ExitTheGame());

    }

    IEnumerator ExitTheGame()
    {
        fadeIn.GetComponent<Animator>().Play("FadeIn");
        thePlayer.SetActive(false);
        mainMusic.Stop();
        yield return new WaitForSeconds(4);
        Application.Quit();
        Debug.Log("You have quit the game");
    }
}

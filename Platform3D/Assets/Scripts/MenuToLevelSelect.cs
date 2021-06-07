using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuToLevelSelect : MonoBehaviour
{
    public GameObject fadeIn;
    public GameObject thePlayer;

    void OnCollisionEnter(Collision collision)
    {
        StartCoroutine(MoveToSelectMenu());

    }

    IEnumerator MoveToSelectMenu()
    {
        fadeIn.GetComponent<Animator>().Play("FadeIn");
        thePlayer.SetActive(false);
        yield return new WaitForSeconds(4);
        thePlayer.SetActive(true);
        SceneManager.LoadScene(5);
    }
}

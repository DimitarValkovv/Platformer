using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NextLevelOnTouch : MonoBehaviour
{
    public GameObject thePlayer;
    public GameObject nextLevelMenu;
    public GameObject timeBox;
    public GameObject scoreBox;
    public GameObject theScore;
    public GameObject totalScore;
    public GameObject timeLeft;
    public GameObject rawImage;

    public int timeCalc;
    public int scoreCalc;
    public int totalScored;

    public GameObject nextLevelButton;

    void OnTriggerEnter(Collider other)
    {
      if(other.tag == "Player")
        {
            StartCoroutine(NextLevel());
            StartCoroutine(CalculateScore());
        }  
    }

    IEnumerator NextLevel()
    {
        yield return new WaitForSecondsRealtime(0.4f);
        timeCalc = GlobalTimer.extendScore * 10;
        timeLeft.GetComponent<Text>().text = "Time: " + GlobalTimer.extendScore + " x 10";
        theScore.GetComponent<Text>().text = "Score: " + GlobalScore.currentScore;
        totalScored = GlobalScore.currentScore + timeCalc;
        totalScore.GetComponent<Text>().text = "Total Score: " + totalScored;
        Time.timeScale = 0;
        nextLevelMenu.SetActive(true);
        timeBox.SetActive(false);
        scoreBox.SetActive(false);
        nextLevelButton.SetActive(true);
    }

    IEnumerator CalculateScore()
    {
        yield return new WaitForSecondsRealtime(0.5f);
        timeLeft.SetActive(true);
        rawImage.SetActive(true);
        theScore.SetActive(true);
        totalScore.SetActive(true);
    }
}

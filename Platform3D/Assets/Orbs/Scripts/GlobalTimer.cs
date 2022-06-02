using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalTimer : MonoBehaviour
{

    public GameObject timeObject01;
    public bool isTakingTime = false;
    public int theSeconds = 30;
    public static int extendScore;

    void Update()
    {
        extendScore = theSeconds;
        if(isTakingTime == false)
        {
            StartCoroutine(SubtractSecond());
        }
    }

    IEnumerator SubtractSecond()
    {
        isTakingTime = true;
        theSeconds -= 1;
        timeObject01.GetComponent<Text>().text = "Time: " + theSeconds;
        yield return new WaitForSeconds(1);
        isTakingTime = false;
    }
}

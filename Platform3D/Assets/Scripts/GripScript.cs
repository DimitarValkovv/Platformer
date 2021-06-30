using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GripScript : MonoBehaviour
{
    public GameObject thePlayer;
    public GameObject theLedge;


     void OnTriggerEnter(Collider other)
    {
        thePlayer.transform.parent = theLedge.transform;  
    }

     void OnTriggerExit(Collider other)
    {
        thePlayer.transform.parent = null;  
    }
}

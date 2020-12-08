using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FloorText : MonoBehaviour
{   
    public static int counter = 0;
    Text score;
    public void  Start()
    {   //Counts the players score
        score = GetComponent<Text>();

    }


    void Update()
    {
        score.text = "Score: "+ counter;

    }

}

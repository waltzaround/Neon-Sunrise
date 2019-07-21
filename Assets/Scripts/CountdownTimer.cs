using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountdownTimer : MonoBehaviour
{
    public float timeLeft = 120.0f;
    public GameObject textMesh;
    //public Text countdownText; //used for countdown

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
        textMesh.GetComponent<TextMesh>().text = "Time Left:" + (timeLeft).ToString("0") + "s";
        //countdownText.text = "Time Remaining: " + (timeLeft).ToString("0") + " 's";
        if (timeLeft < 0)
        {
           Debug.Log("Game Over!!!!");
        }
    }
}

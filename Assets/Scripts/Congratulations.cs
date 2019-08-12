using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Congratulations : MonoBehaviour
{
    public GameObject congratulations;
    //public float timeLeft = 120.0f;

    // grab time from countdown timer
    GameObject theTime;

    public bool gameRunning;
    // Start is called before the first frame update
    void Start()
    {
        // Freeze the game as soon as it starts and display the welcome text
        gameRunning = false;
        Time.timeScale = 0.0f;
        congratulations.GetComponent<Text>().text = "Welcome to PewPewVR!\n Touch the headset button or tap and start making pew pew noises to play.";
        congratulations.SetActive(true);

        theTime = GameObject.Find("model");
    }

    // Update is called once per frame
    void Update()
    {
        if (gameRunning)
        {
            CountdownTimer countdownTimer = theTime.GetComponent<CountdownTimer>();
            if (countdownTimer.timeLeft <= 0)
            {
                congratulations.GetComponent<Text>().text = "Game Over!\n Final Score: " + GlobalVariables.score.ToString() + "\nTouch the VR button to restart.";
                congratulations.SetActive(true);
                if (Input.touchCount > 0 || Input.GetKeyDown(KeyCode.Space))
                {
                    congratulations.SetActive(false);
                }
            }
        } else
        {
            if (Input.touchCount > 0 || Input.GetKeyDown(KeyCode.Space))
            {
                Time.timeScale = 1.0f;
                gameRunning = true;
                congratulations.SetActive(false);
            }
        }
    }
}

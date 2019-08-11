using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CountdownTimer : MonoBehaviour
{
    public float timeLeft = 120.0f;
    public GameObject textMesh;

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
        textMesh.GetComponent<TextMesh>().text = "Time Left:" + (timeLeft).ToString("0") + "s";
        if (timeLeft <= 0)
        {
            Time.timeScale = 0.0f;
            // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            // Time.timeScale = 1.0f;
           if (Input.touchCount > 0  || Input.GetKeyDown(KeyCode.Space)){
               Time.timeScale = 1.0f;
               SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
               GlobalVariables.score = 0;
           }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Congratulations : MonoBehaviour
{
    public GameObject congratulations;
    public float timeLeft = 120.0f;
    // Start is called before the first frame update
    void Start()
    {
        congratulations.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft <= 0)
        {
            congratulations.SetActive(true);
           if (Input.touchCount > 0 ){
               congratulations.SetActive(false);
           }
        }
    }
}

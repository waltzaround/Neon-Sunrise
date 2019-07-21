using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayScore : MonoBehaviour
{
    // public TextMesh score; //used for Score
    public GameObject textMesh;
    // public TextMesh score = GameObject.Find("score").GetComponent<TextMesh>();
    // Update is called once per frame
    void Update()
    {
        textMesh.GetComponent<TextMesh>().text = "Score: " + GlobalVariables.score.ToString();
        // score.text = "Score: " + GlobalVariables.score.ToString();
        Debug.Log(GlobalVariables.score.ToString());
    }
}

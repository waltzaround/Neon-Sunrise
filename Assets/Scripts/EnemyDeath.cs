using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeath : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    public void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Hit by laser");
        if (collision.gameObject.tag == "bullet")
        {
            gameObject.SetActive(false);
            GlobalVariables.score += 5;
            Debug.Log("Sucessfully triggered");
        }
    }
}

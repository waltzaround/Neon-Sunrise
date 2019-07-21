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
        if (collision.gameObject.tag == "bullet") {
          Debug.Log(collision.gameObject.name);
            if(collision.gameObject.name.StartsWith("ChainLaser")) {
              GlobalVariables.score += 11;
            } else {
              GlobalVariables.score += 5;
            }
            gameObject.SetActive(false);
        }
    }
}

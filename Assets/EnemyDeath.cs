using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeath : MonoBehaviour
{

    public GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Hit by laser");
        if (collision.gameObject.tag == "bullet")
        {
            enemy.SetActive(false);
            Debug.Log("Sucessfully triggered");
        }
    }
}

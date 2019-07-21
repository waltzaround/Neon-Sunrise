using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeath : MonoBehaviour
{
    public GameObject explosion;
    public Vector3 explosionOffset;
    public AudioSource aSource;

    // Start is called before the first frame update
    void Start()
    {

    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "bullet") {
            if(collision.gameObject.name.StartsWith("ChainLaser")) {
              GlobalVariables.score += 11;
            } else {
              GlobalVariables.score += 5;
            }
            if (explosion != null) {
                GameObject explosionFX = Instantiate(explosion, transform.position + explosionOffset, Quaternion.identity) as GameObject;
                Destroy(explosionFX, 5);
            }
            aSource.Play();
            gameObject.SetActive(false);
        }
    }
}

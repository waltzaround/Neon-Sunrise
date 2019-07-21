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
        if (collision.gameObject.tag == "bullet")

        {

            if (explosion != null)
            {
                print("Instantiating explosion");
                //partSystem = gameObject.GetComponent<ParticleSystem>()
                GameObject explosionFX = Instantiate(explosion, transform.position + explosionOffset, Quaternion.identity) as GameObject;
                //explosionFX.Play();
                Destroy(explosionFX, 5);
            }
            aSource.Play();
            gameObject.SetActive(false);
            GlobalVariables.score += 5;
        }
    }
}

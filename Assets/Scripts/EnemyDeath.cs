using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeath : MonoBehaviour
{

    public GameObject explosion;
    public Vector3 explosionOffset;

    // Start is called before the first frame update
    void Start()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        //Debug.Log("Hit by laser");
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

            print("Instantiated explosion");
            
            gameObject.SetActive(false);
            //Debug.Log("Sucessfully triggered");
        }
    }
}

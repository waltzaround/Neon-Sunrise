using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletExplosion : MonoBehaviour
{
  public float force;
  public int numberOfBullets;
  public ObjectPooler bulletPool;
  private int bulletsLeftToFire;
  enum Axis {
    x,y,z
  }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "bullet")
        {
            bulletsLeftToFire = numberOfBullets;
            fireBullets(numberOfBullets);
        }
    }

    private void fireBullets(int numberOfBullets) {
      for(int i = 0; i < numberOfBullets; i++) {
        fireBullet();
      }
    }

    private void fireBullet() {
      GameObject bullet = bulletPool.GetPooledObject();
      bullet.SetActive(true);
      bullet.transform.position = gameObject.transform.position;
      bullet.transform.rotation = Random.rotation;//Quaternion.Euler(angleToFire);
      bullet.GetComponent<Rigidbody>().AddForce(bullet.transform.forward * force);
    }
}

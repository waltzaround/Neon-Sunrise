using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class BulletShooter : MonoBehaviour
{
  public ObjectPooler objectPooler;
  public GameObject self;
  public float speed = 100f;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) || Input.touchCount > 0) {
          GameObject shootingBullet = objectPooler.GetPooledObject();
          shootingBullet.SetActive(true); 
          shootingBullet.transform.rotation = objectPooler.objectToPool.transform.rotation;
          shootingBullet.transform.position = objectPooler.objectToPool.transform.position;
          Rigidbody shootingBulletRigidbody = shootingBullet.GetComponent<Rigidbody>();
          
          shootingBulletRigidbody.AddForce(Camera.main.transform.forward * speed);
        }
    }
}

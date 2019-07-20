using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{
  public GameObject bullet;

  public float disableBulletDistance;
  void Update() {
    float distanceFromCamera = Vector3.Distance(bullet.transform.position, Camera.main.transform.position);
    if(distanceFromCamera > disableBulletDistance) {
      DisableBullet();
    }
  }
  void OnCollisionEnter(Collision collision) 
  {
    DisableBullet();
  }

  void DisableBullet() {
    bullet.SetActive(false);
    bullet.GetComponent<Rigidbody>().velocity = Vector3.zero;
    bullet.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
  }
}

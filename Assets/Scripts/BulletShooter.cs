using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class BulletShooter : MonoBehaviour
{
  public ObjectPooler objectPooler;
  public float speed = 100f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
          GameObject shootingBullet = objectPooler.GetPooledObject();
          shootingBullet.SetActive(true);
          shootingBullet.transform.position = Camera.main.transform.position;
          shootingBullet.transform.rotation = Camera.main.transform.rotation;
          Rigidbody shootingBulletRigidbody = shootingBullet.GetComponent<Rigidbody>();
          
          shootingBulletRigidbody.AddForce(Camera.main.transform.forward * speed);
        }
    }
}

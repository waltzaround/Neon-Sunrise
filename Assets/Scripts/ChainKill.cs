using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChainKill : MonoBehaviour
{
  public ObjectPooler displayTextObjectPool;
  private GameObject displayText;
  public void Start() {
    displayText = displayTextObjectPool.GetPooledObject();
  }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "bullet" && collision.gameObject.name.StartsWith("ChainLaser")) {
          GameObject displayText = displayTextObjectPool.GetPooledObject();
          displayText.SetActive(true);
          displayText.transform.position = gameObject.transform.position;
          displayText.transform.LookAt(Camera.main.transform);
          Invoke("disableText", 5.0f);
        }
    }

    public void disableText() {
      displayText.SetActive(false);
    }
}

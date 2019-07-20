using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooler : MonoBehaviour
{
  public GameObject objectToPool;
  public int poolSize = 50;
  public List<GameObject> pooledObjects;
  public bool willGrow;
  void Start()
  {
      pooledObjects = new List<GameObject>();
      for(int i = 0; i < poolSize; i++) 
      {
        GameObject obj = (GameObject)Instantiate(objectToPool);
        obj.SetActive(false);
        pooledObjects.Add(obj);
      }
  }

  public GameObject GetPooledObject () {
    for(int i = 0; i < pooledObjects.Count; i++) {
      if(!pooledObjects[i].activeInHierarchy) {
        return pooledObjects[i];
      }
    }
    if(willGrow) {
      pooledObjects.Add((GameObject)Instantiate(objectToPool));
    }
    return null;
  }
}

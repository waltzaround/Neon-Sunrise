using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{
 List<Vector3> EnemyArray;

 void PopulateEnemyArray()
 {
  EnemyArray = new List<Vector3>();
  for (var i = 0; i < 50; i++)
  {
   //Scale 10 if need bigger range
   Vector3 enemyPosition = Random.onUnitSphere * (10);
   enemyPosition.z = Mathf.Abs(enemyPosition.z);
   EnemyArray.Add(enemyPosition);
  }
  for (var i = 0; i < EnemyArray.Count; i++)
  {
   Debug.Log(EnemyArray[i]);
  }
 }

 // Start is called before the first frame update
 void Start()
 {
  PopulateEnemyArray();
 }

 // Update is called once per frame
 void Update()
 {

 }
}

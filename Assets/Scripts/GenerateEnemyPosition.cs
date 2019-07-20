using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateEnemyPosition : MonoBehaviour
{
 public static Vector3 GenerateEnemyPositionMethod()
 {
   //Scale 10 if need bigger range
   Vector3 enemyPosition = Random.onUnitSphere * (10);
   enemyPosition.z = Mathf.Abs(enemyPosition.z);
   Debug.Log(enemyPosition);
   return enemyPosition ;
 }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateEnemyPosition : MonoBehaviour
{
 public static Vector3 GenerateEnemyPositionMethod()
 {
   //Scale 10 if need bigger range
   Vector3 enemyPosition = Random.onUnitSphere * (30);
   enemyPosition.y = Mathf.Abs(enemyPosition.y);
   Debug.Log(enemyPosition);
   return enemyPosition ;
 }
}

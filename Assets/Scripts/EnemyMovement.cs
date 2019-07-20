using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    // Adjust the speed for the application.
    public float speed = 1.0f;
    public float X;
    public float Y;
    public float Z;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float step =  speed * Time.deltaTime; // calculate distance to move
        // Spin the object around the world origin at 20 degrees/second.
        transform.RotateAround(Vector3.zero, Vector3.up, 5 * Time.deltaTime);
        // /Vector3Int.zero
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(X, Y, Z), step);
    }
}
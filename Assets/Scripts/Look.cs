using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Look : MonoBehaviour
{
    Vector3 playerLocation;
    // Start is called before the first frame update
    void Start()
    {
        playerLocation = new Vector3(0.0f, 1.6f, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(playerLocation);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollingRock : MonoBehaviour
{
    public float resetXPosition = -20f;
    public float teleportXDistance = 40f;

    void Update()
    {
        if (transform.position.x < resetXPosition)
        {
            transform.position += new Vector3(teleportXDistance, 0, 0);
        }
    }
}
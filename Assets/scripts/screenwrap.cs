using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class screenwrap : MonoBehaviour
{
    // Start is called before the first frame update
    public float screenWidth = 10f;  // Adjust based on screen size
    public float screenHeight = 10f;

    void Update()
    {
        Vector3 position = transform.position;

        // Wrap horizontally
        if (position.x > screenWidth) position.x = -screenWidth;
        if (position.x < -screenWidth) position.x = screenWidth;

        // Wrap vertically
        if (position.z > screenHeight) position.z = -screenHeight;
        if (position.z < -screenHeight) position.z = screenHeight;

        transform.position = position;
    }
}


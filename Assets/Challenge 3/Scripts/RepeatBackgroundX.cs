using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackgroundX : MonoBehaviour
{
    private Vector3 startPos;
    private float repeatWidth;

    void Start()
    {
        startPos = transform.position; // Establish the default starting position 
        //Challenge 5: Change size.y to size.x
        repeatWidth = GetComponent<BoxCollider>().size.x / 2; // Set repeat width to half of the background
    }

    void Update()
    {
        // If background moves left by its repeat width, move it back to start position
        //Challenge 5: Change startPos.y to startPos.x
        if (transform.position.x < startPos.x - repeatWidth)
        {
            transform.position = startPos;
        }
    }

 
}



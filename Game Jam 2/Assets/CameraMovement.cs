﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    public float boundX;
    public float boundY;

    private Vector2 mousePos;
    private Vector2 desiredPosition;

    float speed = 0.1f;

    // Use this for initialization
    void Start()
    {
        boundX = Screen.width - 50;
        boundY = Screen.height - 50;
        Debug.Log(Input.mousePosition);
        Debug.Log(boundX);
        Debug.Log(boundY);
    }

    void Update()
    {
        mousePos = Input.mousePosition;
        if (mousePos.x > boundX)
        {
            transform.position += new Vector3(speed,0.0f, 0.0f);
        }
        else if (mousePos.x < 50)
        {
            transform.position -= new Vector3(speed, 0.0f, 0.0f);
        }
        else if (mousePos.y > boundY)
        {
            transform.position += new Vector3(0.0f,0.0f, speed);
        }
        else if (mousePos.y < 50)
        {
            transform.position -= new Vector3(0.0f, 0.0f, speed);
        }
    }
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EneMove2 : MonoBehaviour
{
    Vector2 pointA = new Vector2(65.521f, -1.074f);
    Vector2 pointB = new Vector2(60.521f, -1.074f);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         transform.position = Vector2.Lerp(pointA, pointB, Mathf.PingPong(Time.time, 1));

    }
}
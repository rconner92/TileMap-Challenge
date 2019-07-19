using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EneMove : MonoBehaviour
{
    Vector2 pointA = new Vector2(65.521f, 4.872f);
    Vector2 pointB = new Vector2(60.521f, 4.872f);

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

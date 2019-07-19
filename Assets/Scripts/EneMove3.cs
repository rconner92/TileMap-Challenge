using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EneMove3 : MonoBehaviour
{
    Vector2 pointA = new Vector2(82.68f, 5.712f);
    Vector2 pointB = new Vector2(79f, 5.712f);

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

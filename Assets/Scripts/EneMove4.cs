using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EneMove4 : MonoBehaviour
{
    Vector2 pointA = new Vector2(82.981f, 1.612f);
    Vector2 pointB = new Vector2(79.95f, 1.612f);

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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove3 : MonoBehaviour
{
    Vector2 pointA = new Vector2(-4.548f, 0.522f);
    Vector2 pointB = new Vector2(-2.823f, 0.522f);

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

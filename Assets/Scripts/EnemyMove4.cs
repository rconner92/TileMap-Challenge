using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove4 : MonoBehaviour
{
    Vector2 pointA = new Vector2(3.511f, 0.502f);
    Vector2 pointB = new Vector2(2.20f, 0.502f);

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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundMove : MonoBehaviour
{

    float speed = -3f;
    Vector2 startPos;

    void Start()
    {
        startPos = transform.position;
    }


    void Update()
    {
        float newPos = Mathf.Repeat(Time.time * speed, 20);
        transform.position = startPos + Vector2.right * newPos;
        
    }
}

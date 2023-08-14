using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ceiling : MonoBehaviour
{
    public Vector2 rightEdge;


    void Start()
    {
        rightEdge = new Vector2(Camera.main.pixelWidth, Camera.main.pixelHeight);
        rightEdge = Camera.main.ScreenToWorldPoint(rightEdge);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = rightEdge;
    }
}

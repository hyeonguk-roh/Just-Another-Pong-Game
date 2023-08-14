using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor : MonoBehaviour
{
    public Vector2 leftEdge;


    void Start()
    {
        leftEdge = Camera.main.ScreenToWorldPoint(Vector2.zero);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = leftEdge;
    }
}

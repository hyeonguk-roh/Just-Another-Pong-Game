using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    protected Rigidbody2D _rigidbody;
    public float speed = 5.0f;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }
}

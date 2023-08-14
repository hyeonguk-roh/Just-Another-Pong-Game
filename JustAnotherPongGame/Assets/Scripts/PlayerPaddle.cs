using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPaddle : Paddle
{
    private Vector2 _direction;
    private int updown = 0;

    void Update()
    {
        if (updown == 1) {
            _direction = Vector2.right;
            Debug.Log("Going Right");
        } else if (updown == -1) {
            _direction = -Vector2.right;
            Debug.Log("Going Left");
        } else {
            _direction = Vector2.zero;
        }
    }

    void FixedUpdate()
    {
        if (_direction.sqrMagnitude != 0) {
            _rigidbody.AddForce(_direction * speed);
        }
    }

    public void GoRight()
    {
        updown = 1;
    }

    public void GoLeft()
    {
        updown = -1;
    }

    public void Unpressed()
    {
        updown = 0;
    }
}

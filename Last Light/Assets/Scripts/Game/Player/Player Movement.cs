using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    // Player movement Controles with the Movement speed 
    [SerializeField]
    private float _speed;

    private Rigidbody2D _rigidbody2;
    private Vector2 _movementInput;

    private void Awake()
    {
        _rigidbody2 = GetComponent<Rigidbody2D>();
    }


    private void FixedUpdate()
    {
        _rigidbody2.velocity = _movementInput* _speed;
    }

    private void OnMove(InputValue inputValue)
    {
        _movementInput = inputValue.Get<Vector2>();  
    }



}

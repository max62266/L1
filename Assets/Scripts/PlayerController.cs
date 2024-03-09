﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerController : MonoBehaviour
{
    public float Gravity = 9.8f;
    public float JumpForce = 7;
    public float Speed = 5;
    public Animator animator;

    private Vector3 _moveVector;
    private float _fallVelocity = 0;

    private CharacterController _characterController;
  
    void Start()
    {
        _characterController = GetComponent<CharacterController>();
    }

    void Update()
    {
        _moveVector = Vector3.zero;
        var runDirection = 0;

        if (Input.GetKey(KeyCode.W))
        {
            _moveVector += transform.forward;
            runDirection = 1;
        }
        if (Input.GetKey(KeyCode.S))
        {
            _moveVector -= transform.forward;
             runDirection = 2;
        }
        if (Input.GetKey(KeyCode.D))
        {
            _moveVector += transform.right;
             runDirection = 3;
        }
        if (Input.GetKey(KeyCode.A))
        {
            _moveVector -= transform.right;
             runDirection = 4;
        }

        if (Input.GetKeyDown(KeyCode.Space) && _characterController.isGrounded)
        {
            _fallVelocity = -JumpForce;
        }
        animator.SetInteger("Run Direction", runDirection);
    }

    void FixedUpdate()
    {
        _characterController.Move(_moveVector * Speed * Time.fixedDeltaTime);

        _fallVelocity += Gravity * Time.fixedDeltaTime;
        _characterController.Move(Vector3.down * _fallVelocity * Time.fixedDeltaTime);

        if(_characterController.isGrounded)
        {
            _fallVelocity = 0;
        }
    }
}
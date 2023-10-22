using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

//a simple character controller script that use Unity Input system. Full set up can be seen on
//https://www.youtube.com/watch?v=WNV9l04s8t4&list=PLBcfp6HMOJwzDcdCzoAx3jJKm7sIcBXJZ&index=1

[RequireComponent(typeof(CharacterController))]

public class Mover : MonoBehaviour
{
    private Vector2 _input;
    private CharacterController _characterController;
    private Vector3 _direction;

    [SerializeField] private float smoothTime = 0.05f;

    [SerializeField] private float speed;
    private float _currenVelocity;

    float yPos;
    
    private void Awake()
    {
        _characterController = GetComponent<CharacterController>();
    }

    private void Start()
    {
        Debug.Log("Avoid obstacles! move using WASD keys");
    }

    private void Update()
    {
        // prevents the player 
        if (_input.sqrMagnitude == 0) return;
        //face the direction of movement
        var targetAngle = Mathf.Atan2(_direction.x, _direction.z) * Mathf.Rad2Deg;
        var angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref _currenVelocity, smoothTime);
        transform.rotation = Quaternion.Euler(0.0f, angle, 0.0f);

        _characterController.Move(_direction * speed * Time.deltaTime);

    }
    public void Move(InputAction.CallbackContext context)
    {
        _input = context.ReadValue<Vector2>();

        // instead of moving to y axis, we move to z axis
        _direction = new Vector3(_input.x,0f,_input.y);

    }
}
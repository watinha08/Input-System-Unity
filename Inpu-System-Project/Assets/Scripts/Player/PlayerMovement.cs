using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    private CharacterControls characterControls;
    private Transform playerTransform;
    private Vector2 moveDirection;

    [SerializeField] private float velocity;

    private void Awake()
    {
        playerTransform = GetComponent<Transform>();

        characterControls = new CharacterControls();
        characterControls.PlayerBehavior.Move.started += OnMoveInputReceived;
        characterControls.PlayerBehavior.Move.started += PrintInputAction;
        characterControls.PlayerBehavior.Move.canceled += OnMoveInputReceived;
        characterControls.PlayerBehavior.Move.performed += OnMoveInputReceived;
    }

    private void PrintInputAction(InputAction.CallbackContext context)
    {
        print(context.ReadValue<Vector2>());
    }

    private void Update()
    {
        MovePlayer();
    }

    private void MovePlayer()
    {
        playerTransform.Translate(new Vector2(moveDirection.x, moveDirection.y) * velocity * Time.deltaTime);
    }
    private void OnMoveInputReceived(InputAction.CallbackContext context)
    {
        moveDirection = context.ReadValue<Vector2>();
    }

    private void OnEnable()
    {
        characterControls.Enable();
    }

    private void OnDisable()
    {
        characterControls.PlayerBehavior.Move.started -= OnMoveInputReceived;
        characterControls.PlayerBehavior.Move.canceled -= OnMoveInputReceived;
        characterControls.PlayerBehavior.Move.performed -= OnMoveInputReceived;
        characterControls.Disable();
    }
}

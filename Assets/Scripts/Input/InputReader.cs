using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using static Controls;

[CreateAssetMenu(fileName = "New InputReader", menuName = "Input/Input Reader")]
public class InputReader : ScriptableObject, IPlayerActions
{
    public event Action<Vector2> MoveEvent;
    public event Action<bool> PrimaryFireEvent;
    public event Action<Vector2> AimSecondaryEvent;
    public event Action<bool> SecondaryFireEvent;

    public Vector2 AimPrimaryPosition { get; private set; }
    
    private Controls controls;

    private void OnEnable() {
        if (controls == null) {
            controls = new Controls();
            controls.Player.SetCallbacks(this);
        }
        controls.Player.Enable();      
    }

    public void OnMove(InputAction.CallbackContext context) {
        MoveEvent?.Invoke(context.ReadValue<Vector2>());
    }

    public void OnPrimaryFire(InputAction.CallbackContext context) {
        if(context.performed) {
            PrimaryFireEvent?.Invoke(true);
        } else {
            if(context.canceled) {
                PrimaryFireEvent?.Invoke(false);
            }
        }
    }

    public void OnSecondaryFire(InputAction.CallbackContext context) {
      if(context.performed) {
            SecondaryFireEvent?.Invoke(true);
        } else {
            if(context.canceled) {
                SecondaryFireEvent?.Invoke(false);
            }
        }
    }

    public void OnAimPrimary(InputAction.CallbackContext context)
    {
        AimPrimaryPosition = context.ReadValue<Vector2>();
    }

    public void OnAimSecondary(InputAction.CallbackContext context)
    {
        AimSecondaryEvent?.Invoke(context.ReadValue<Vector2>());
    }
}

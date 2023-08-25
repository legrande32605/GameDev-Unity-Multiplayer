using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

public class PlayerAiming : NetworkBehaviour
{
    [Header("References")]
    [SerializeField] private InputReader inputReader;
    [SerializeField] private Transform turretTransform;
    [SerializeField] private Transform machinegunTransform;

    [Header("Settings")]
    [SerializeField] private float mgTuringRate = 30f;

    private Vector2 previousMachineGunInput;

    private void LateUpdate() {
        if (!IsOwner) { return; }

        Vector2 aimPrimaryScreenPosition = inputReader.AimPrimaryPosition;
        Vector2 aimWorldPosition = Camera.main.ScreenToWorldPoint(aimPrimaryScreenPosition);

        turretTransform.up = new Vector2 (
            aimWorldPosition.x - turretTransform.position.x,
            aimWorldPosition.y - turretTransform.position.y);


                
        float zRotation = previousMachineGunInput.x * -mgTuringRate * Time.deltaTime;
        machinegunTransform.Rotate(0f,0f, zRotation);
    }

    public override void OnNetworkSpawn() {
        if (!IsOwner) { return; }

        inputReader.AimSecondaryEvent += HandleMachinegun;

    }

    public override void OnNetworkDespawn() {
        if (!IsOwner) { return; }

        inputReader.AimSecondaryEvent -= HandleMachinegun;

    }

    private void HandleMachinegun(Vector2 movementInput) {
        previousMachineGunInput = movementInput;
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

public class ProjectileLauncher : NetworkBehaviour
{
    [Header("References")]
    [SerializeField] private InputReader inputReader;
    [SerializeField] private Transform projectileSpawnPoint;
    [SerializeField] private GameObject serverProjectilePrefab;
    [SerializeField] private GameObject clientProjectilePrefab;

    [Header("Settings")]
    [SerializeField] private float ProjectileSpeed = 30f;

    private bool shouldFire;

    public override void OnNetworkSpawn() {
        if (!IsOwner) { return; }
        
        inputReader.PrimaryFireEvent += HandlePrimaryFire;
    }

    public override void OnNetworkDespawn() {
        if (!IsOwner) { return; }
        
        inputReader.PrimaryFireEvent -= HandlePrimaryFire;
    }

    private void Update() {
        if (!IsOwner) { return; }
        
        if (!shouldFire) { return; }

        PrimaryFireServerRPC(projectileSpawnPoint.position, projectileSpawnPoint.up);
        SpawnDummyProjectile(projectileSpawnPoint.position, projectileSpawnPoint.up);
    }

    private void HandlePrimaryFire(bool shouldFire)
    {
        this.shouldFire = shouldFire;
    }

    [ServerRpc]
    public void PrimaryFireServerRPC(Vector3 spawnPos, Vector3 direction) {
        GameObject projectileInstance = Instantiate(serverProjectilePrefab, spawnPos, Quaternion.identity);
        projectileInstance.transform.up = direction;

        SpawnDummyProjectilClientRPC(spawnPos, direction);
    }

    [ClientRpc]
    public void SpawnDummyProjectilClientRPC(Vector3 spawnPos, Vector3 direction) {
        GameObject projectileInstance = Instantiate(clientProjectilePrefab, spawnPos, Quaternion.identity);
        projectileInstance.transform.up = direction;
    }

    private void SpawnDummyProjectile(Vector3 spawnPos, Vector3 direction) {
        GameObject projectileInstance = Instantiate(clientProjectilePrefab, spawnPos, Quaternion.identity);
        projectileInstance.transform.up = direction;
    }
}

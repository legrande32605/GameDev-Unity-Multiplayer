using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

public class MGProjectileLauncher : NetworkBehaviour
{
    [Header("References")]
    [SerializeField] private InputReader inputReader;
    [SerializeField] private Transform mgProjectileSpawnPoint;
    [SerializeField] private GameObject serverMGProjectilePrefab;
    [SerializeField] private GameObject clientMGProjectilePrefab;

    [Header("Settings")]
    [SerializeField] private float mgProjectileSpeed = 30f;

    private bool shouldFire;
    
    public override void OnNetworkSpawn() {
        if (!IsOwner) { return; }

        inputReader.SecondaryFireEvent += HandleSecondaryFire;
    }
    
    public override void OnNetworkDespawn() {
        if (!IsOwner) { return; }

        inputReader.SecondaryFireEvent -= HandleSecondaryFire;
    }

    void Update()
    {
        if (!IsOwner) { return; }
        
        if (!shouldFire) { return; }

        SecondaryFireServerRPC(mgProjectileSpawnPoint.position, mgProjectileSpawnPoint.up);
        SpawnDummyMGProjectile(mgProjectileSpawnPoint.position, mgProjectileSpawnPoint.up);
    }

    private void HandleSecondaryFire(bool shouldFire)
    {
        this.shouldFire = shouldFire;
    }

    [ServerRpc]
    public void SecondaryFireServerRPC(Vector3 spawnPos, Vector3 direction) {
        GameObject mgProjectileInstance = Instantiate(serverMGProjectilePrefab, spawnPos, Quaternion.identity);
        mgProjectileInstance.transform.up = direction;

        SpawnDummyMGProjectilClientRPC(spawnPos, direction);
    }

    [ClientRpc]
    public void SpawnDummyMGProjectilClientRPC(Vector3 spawnPos, Vector3 direction) {
        GameObject mgProjectileInstance = Instantiate(clientMGProjectilePrefab, spawnPos, Quaternion.identity);
        mgProjectileInstance.transform.up = direction;
    }

    private void SpawnDummyMGProjectile(Vector3 spawnPos, Vector3 direction) {
        GameObject mgProjectileInstance = Instantiate(clientMGProjectilePrefab, spawnPos, Quaternion.identity);
        mgProjectileInstance.transform.up = direction;
    }
}
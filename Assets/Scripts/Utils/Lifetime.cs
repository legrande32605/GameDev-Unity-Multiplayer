using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;


public class Lifetime : MonoBehaviour
{
    [Header("Settings")]
    [SerializeField] private float lifetime = 2f;

    private DateTime startTime;

    private void Start() {
        Destroy(gameObject, lifetime);        
    }
}

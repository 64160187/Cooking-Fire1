using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Weapon : MonoBehaviour
{
    [SerializeField] Camera fpCamera;
    [SerializeField] float range = 100f;
    [SerializeField] InputActionReference attack;

    private void OnEnable()
    {
        attack.action.performed += PerformAttack;
    }
    private void OnDisable()
    {
        attack.action.performed -= PerformAttack;
    }

    private void PerformAttack(InputAction.CallbackContext obj)
    {
        Shoot();
    }

    private void Shoot()
    {
        RaycastHit hits;
        if (Physics.Raycast(fpCamera.transform.position, fpCamera.transform.forward, out hits, range))
        {
            //if enemy, attack, life calculation, etc.
            Debug.Log("hit " + hits.transform.name);
        }
        else
        {
            return;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

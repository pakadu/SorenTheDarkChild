using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;

public class WeaponController : MonoBehaviour
{
    // Script for all weapon controlling

    [Header("Weapon Stats")]
    public GameObject prefab;
    public float damage;
    public float speed;
    public float cooldownDuration;
    float currentCooldown;
    public int pierce;

    protected virtual void Start()
    {
        currentCooldown = cooldownDuration; // So i cant spam shootin
    }

    protected virtual void Update()
    {
        currentCooldown -= Time.deltaTime;
        if(currentCooldown <= 0f){ // attack reset on 0
            Attack();
        } //
    }

    protected virtual void Attack(){
        currentCooldown = cooldownDuration;
    }
}
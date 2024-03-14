using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileController : WeaponController
{
    public float range; // Range of the projectile

    protected override void Start()
    {
        base.Start();
    }

    protected override void Attack()
{
    base.Attack();
    GameObject spawnedProjectile = Instantiate(prefab);
    spawnedProjectile.transform.position = transform.position; //Position to the parent object (player)

    // Calculate direction from player to mouse cursor
    Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    Vector3 direction = (mousePosition - transform.position).normalized;
    
    // Set direction for the projectile
    ProjectileBehaviour projectileBehaviour = spawnedProjectile.GetComponent<ProjectileBehaviour>();
    projectileBehaviour.DirectionChecker(direction);
    
    // Set range for the projectile
    ProjectileController projectileController = spawnedProjectile.GetComponent<ProjectileController>();
    projectileController.range = range;
}
}

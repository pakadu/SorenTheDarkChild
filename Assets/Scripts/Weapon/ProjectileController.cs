using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileController : WeaponController
{

    
    protected override void Start()
    {
        base.Start();
    }

    protected override void Attack(){
        base.Attack();
        GameObject spawnedProjectile = Instantiate(prefab);
        spawnedProjectile.transform.position = transform.position; //Position to the parent object (pla)
 }
}
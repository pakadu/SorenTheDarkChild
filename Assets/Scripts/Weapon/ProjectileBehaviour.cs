using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBehaviour : ProjectileWeaponBehaviour
{
    ProjectileController pc;

    protected override void Start()
    {
        base.Start();
        pc = FindAnyObjectByType<ProjectileController>();
    }

    void Update()
    {
        transform.position += direction * pc.speed * Time.deltaTime; //set the movement for projectile.
    }
}

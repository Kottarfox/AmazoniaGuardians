using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    public string Name;
    public int Health = 100;
    public int Damage = 25;
    public float FireRate = 2f; 
    public Transform firePoint;
    public GameObject projectilePrefab;

    private void Start()
    {
        InvokeRepeating("Attack", 0f, FireRate);
       // Attack();
    }

   // private void Attack()
    //{
        
    //}

    public void Attack(Enemy enemy)
    {
        Debug.Log("Funciona por favor");
        enemy.TakeDamage(Damage);
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        GameObject targetEnemy = null;
        float closestDistance = Mathf.Infinity;

        foreach (GameObject Enemy in enemies)
        {
            float distanceToEnemy = Vector3.Distance(transform.position, enemy.transform.position);
            if (distanceToEnemy < closestDistance)
            {
                closestDistance = distanceToEnemy;
                targetEnemy = Enemy;
            }
        }

        if (targetEnemy != null)
        {
            Shoot(targetEnemy.transform);
        }


    }

    void Shoot(Transform target)
    {
        GameObject projectile = Instantiate(projectilePrefab, firePoint.position, firePoint.rotation);
        Projectile Projectile = projectile.GetComponent<Projectile>();

       
        if (Projectile != null)
        {
            Projectile.SetTarget(target); // Configura el objetivo del proyectil
            Projectile.SetDamage(Damage); // Configura el daño del proyectil
        }
    }


    public void TakeDamage(int damage)
    {
        Health -= damage;

        if (Health <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
    }
}

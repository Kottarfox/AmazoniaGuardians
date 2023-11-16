using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    public string Name;
    public int Health = 100;
    public int Damage = 25;

    public void Attack(Enemy enemy)
    {
        enemy.TakeDamage(Damage);
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

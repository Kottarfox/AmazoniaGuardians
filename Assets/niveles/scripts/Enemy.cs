using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public string Name;
    public int Health = 50;
    public int Damage = 10;
    public double Speed = 1;


    public void Attack(Tower tower)
    {
        tower.TakeDamage(Damage);
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
        Destroy(gameObject); 
    }
}

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
        Debug.Log($"{Name} is attacking {enemy.Name} and dealing {Damage} damage.");
        enemy.TakeDamage(Damage);
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;
        Debug.Log($"{Name} took {damage} damage. Remaining health: {Health}");

        if (Health <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aliado : MonoBehaviour
{
    class Animal
    {
        public float health;
        public float damage;

        public void TakeDamage(int damage)
        {
            health -= damage;
        }


        public void Attack(Enemigo enemy)
        {
          enemy.TakeDamage(Damage);
        }
    }
}

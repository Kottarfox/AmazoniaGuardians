using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oso : MonoBehaviour
{
    public int health = 100;

    void Update()
    {
        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Debug.Log("Oso derrotado");
        Destroy(gameObject);
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        Debug.Log($"El oso ha recibido {damage} de daño. Salud restante: {health}");
    }
}

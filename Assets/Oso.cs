using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oso : MonoBehaviour
{
    public int health = 100;
    public float detectionRadius = 5f;

    void Update()
    {
        if (health <= 0)
        {
            Die();
        }

        DetectEnemies();
    }

    void Die()
    {
    
        Debug.Log("Oso derrotado");
        Destroy(gameObject);
    }

    void DetectEnemies()
    {

        Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, detectionRadius);

        foreach (Collider2D collider in colliders)
        {
            if (collider.CompareTag("Enemy"))
            {
                
                BlockEnemyPath(collider.gameObject);
            }
        }
    }

    void BlockEnemyPath(GameObject enemy)
    {
      
        Debug.Log($"Oso bloquea el paso del enemigo: {enemy.name}");
   
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        Debug.Log($"El oso ha recibido {damage} de daño. Salud restante: {health}");
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public GameObject enemyPrefab;  
    public int numberOfEnemies = 5;
    public float timeBetweenEnemies = 2f;
    public float speed = 0;

    void Update()
    {
        Move();
    }

    void Move()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }

    internal void TakeDamage(int damage)
    {
        throw new NotImplementedException();
    }

    public float timeBetweenWaves = 10f; 

    private void Start()
    {
        StartCoroutine(SpawnWaves());
    }

    IEnumerator SpawnWaves()
    {
        while (true)
        {
            yield return new WaitForSeconds(timeBetweenWaves);

            for (int i = 0; i < numberOfEnemies; i++)
            {
                //Enemy enemyScript = newEnemyObject.GetComponent<Enemy>();

               /* if (enemyScript != null)
                {
              //      ConfigureEnemy(enemyScript); // Configura las propiedades del enemigo
                }*/

                yield return new WaitForSeconds(timeBetweenEnemies);
            }
        }
    }

    void ConfigureEnemy(Enemy enemy)
    {
        // Configurar las propiedades del enemigo según sea necesario
        enemy.SetName("Enemy"); // Método para asignar un nombre al enemigo
        enemy.SetHealth(50); // Método para establecer la salud del enemigo
        enemy.SetDamage(10); // Método para establecer el daño del enemigo
    }

    private void SetDamage(int v)
    {
        throw new NotImplementedException();
    }

    private void SetHealth(int v)
    {
        throw new NotImplementedException();
    }

    private void SetName(string v)
    {
        throw new NotImplementedException();
    }
}

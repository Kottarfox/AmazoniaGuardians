using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public GameObject enemyPrefab; // Prefab del enemigo
    public Transform spawnPoint;  // Punto de aparición de los enemigos
    public int numberOfEnemies = 5; // Número de enemigos por oleada
    public float timeBetweenEnemies = 2f; // Tiempo entre cada enemigo

    internal void TakeDamage(int damage)
    {
        throw new NotImplementedException();
    }

    public float timeBetweenWaves = 10f; // Tiempo entre oleadas

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
                GameObject newEnemyObject = Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
                Enemy enemyScript = newEnemyObject.GetComponent<Enemy>();

                if (enemyScript != null)
                {
                    ConfigureEnemy(enemyScript); // Configura las propiedades del enemigo
                }

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

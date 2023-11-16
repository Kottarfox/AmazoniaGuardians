using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveManager : MonoBehaviour
{
    public GameObject Enemy; 
    public Transform SpawnPoint;  
    public int numberOfEnemies = 5; 
    public float timeBetweenEnemies = 2f; 
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
                SpawnEnemy();
                yield return new WaitForSeconds(timeBetweenEnemies);
            }
        }
    }

    void SpawnEnemy()
    {
        Instantiate(Enemy, SpawnPoint.position, SpawnPoint.rotation);
    }
}

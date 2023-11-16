using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public Transform[] spawnpoints;

    public GameObject minero;

    private void Start()
    {
        InvokeRepeating("SpawnMinero", 2, 1);
    }

    void SpawnMinero()
    {
        int r = Random.Range(0, spawnpoints.Length);
        GameObject MyMinero = Instantiate(minero, spawnpoints[r].position, Quaternion.identity);
    }
 
}

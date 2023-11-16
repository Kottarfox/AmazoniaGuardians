using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public Transform[] spawnpoints;

    public GameObject[] Enemigo;


    private void Start()
    {
        InvokeRepeating("SpawnMinero", 2, 3);
    }

    void SpawnMinero()
    {
        int r = Random.Range(0, spawnpoints.Length);
        int a = Random.Range(0, Enemigo.Length);
        GameObject MyMinero = Instantiate(Enemigo[a], spawnpoints[r].position, Quaternion.identity);
    }
 
}

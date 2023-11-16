using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpwnaer : MonoBehaviour
{
    public Transform[] spawnpoints;

    public GameObject minero;

    private void Start()
    {
        invokeRepeating("SpawnMinero", 2, 1);
    }

    void SpawnMinero()
    {
        int r = Random.Range(0, spawnpoints.Lenght);
        GameObject MyMinero = Instantiate(minero, spawnpoints[r].position, Quaternion.identity);
    }
 
}

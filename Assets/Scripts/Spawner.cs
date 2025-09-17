using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject enemy;
    public Transform[] spawnPoints;
    public float spawnTimer;
    float nextSpawn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if( Time.time > nextSpawn)
        {
            Instantiate(enemy, spawnPoints[Random.Range(0, spawnPoints.Length)].position, Quaternion.identity);
            nextSpawn = Time.time + spawnTimer;
        }
    }
}

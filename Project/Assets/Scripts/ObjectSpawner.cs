using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject[] spawnObject;
    public float XRange = 1.0f;
    public float YRange = 1.0f;
    public float minSpawnTime = 1.0f;
    public float maxSpawnTime = 10.0f;

    void Start()
    {
        Invoke("SpawnGoal", Random.Range(minSpawnTime, maxSpawnTime));
    }

    void SpawnGoal()
    {
        float OffsetX = Random.Range(-XRange, XRange);
        float OffsetY = Random.Range(-YRange, YRange);
        int spawnObjectIndex = Random.Range(0, spawnObject.Length);
        Instantiate(spawnObject[spawnObjectIndex], transform.position
            + new Vector3(OffsetX, OffsetY, 0.0f), 
            spawnObject[spawnObjectIndex].transform.rotation);
        Invoke("SpawnGoal", Random.Range(minSpawnTime, maxSpawnTime));

    }
    
    
}

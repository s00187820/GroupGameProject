using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject[] spawnGoals;
    public float xRange = 1.0f;
    public float yRange = 1.0f;
    public float minimumSpawnTime = 1.0f;
    public float maximumSpawnTime = 10.0f;
    
    void Start()
    {
        Invoke("SpawnGoal", Random.Range(minimumSpawnTime, maximumSpawnTime));

    }

    void SpawnGoals()
    {
        float xOffset = Random.Range(-xRange, xRange);
        float yOffset = Random.Range(-yRange, yRange);
        int spawnGoalsIndex = Random.Range(0, spawnGoals.Length);
        Instantiate(spawnGoals[spawnGoalsIndex],transform.position + new Vector3(xOffset,yOffset,0.0f), spawnGoals[spawnGoalsIndex].transform.rotation);
        Invoke("SpawnGoal", Random.Range(minimumSpawnTime, maximumSpawnTime));
    }
    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float targetDistance = 10.0f;


    void Start()
    {
        
    }

    
    void Update()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        if((player.transform.position - transform.position).magnitude <= targetDistance)
        {
            Vector3 newPosition = transform.position;
            newPosition.z = player.transform.position.z + targetDistance;
            transform.position = newPosition;
        }
    }
}

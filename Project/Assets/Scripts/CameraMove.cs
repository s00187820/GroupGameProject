using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public float speed = 1.0f;

   

    
    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
    }
}

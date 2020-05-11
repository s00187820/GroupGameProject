using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Movement : MonoBehaviour
{
    float horizontal, vertical, rotation;
    public float rotationSpeed;
    
    Vector3 nextRotation;
    void Update()
    {
       
        nextRotation = Vector3.zero;

       
        rotation = Input.GetAxisRaw("Rotate");
        

      

        

        nextRotation.y = rotation * rotationSpeed * Time.deltaTime;
  
        transform.Rotate(nextRotation);



    }
}

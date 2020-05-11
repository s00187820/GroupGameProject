using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI_Attack : In_Range_Appear
{
    public float laserSpeed = 5;
    public GameObject bulletObject;
    public Transform spawnPoint;
    public float firerate;
    private float timeToShoot;
    public Vector3 laserDirection;
    public GameObject laserSource;

  
    public override void Update()
    {
        if (Vector3.Distance(transform.position, Player.transform.position) <= trackingDistance)
        {
            if (timeToShoot <= Time.time)
            {
                GameObject go = Instantiate(bulletObject, laserSource.transform.position, this.transform.rotation);
                //go.GetComponent<Bullet>().speed = laserSpeed;
                go.GetComponent<Rigidbody>().velocity = (spawnPoint.forward * laserSpeed) * Time.deltaTime;
                timeToShoot = Time.time + firerate;
            }
            

           

        }
    }

   
}

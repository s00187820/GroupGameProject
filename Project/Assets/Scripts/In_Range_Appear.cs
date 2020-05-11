using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class In_Range_Appear : MonoBehaviour
{

    public float trackingDistance = 0;
    string trackTag = "Player";
    MeshRenderer mesh;
    Light Enemylight;
    

    protected GameObject Player;

    // Start is called before the first frame update
    public void Start()
    {
        
        Player = GameObject.FindGameObjectWithTag(trackTag);
        mesh = GetComponent<MeshRenderer>();
        Enemylight = GetComponent<Light>();
           
    }

    // Update is called once per frame
    public virtual void Update()
    {
        
        if (Vector3.Distance(transform.position, Player.transform.position) <= trackingDistance)
        {
            mesh.enabled = true;
            Enemylight.enabled = true;
        }
        else
        {
            mesh.enabled = false;
            Enemylight.enabled = false;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 1.0f;
    public int invert = 1;
   

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float Vertical = Input.GetAxis("Vertical");

        transform.position += (new Vector3 (Input.GetAxis("Horizontal"),Input.GetAxis("Vertical"),0))*moveSpeed*Time.deltaTime;
    }



    //public PathNode CurrentNode;
    //bool shouldMove = true;

    //Vector3 direction;

    //private void Update()
    //{
    //    if (shouldMove)
    //    {
    //        direction = CurrentNode.transform.position - transform.position;
    //        transform.position += direction.normalized * CurrentNode.Speed * Time.deltaTime;
    //        //transform.forward = direction;
    //    }
    //}

    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.gameObject.CompareTag("PathNode") && other.gameObject.name == CurrentNode.name)
    //    {
    //        PathNode node;

    //        if (other.TryGetComponent<PathNode>(out node))
    //        {
    //            if (node.NextNode != null)
    //                CurrentNode = node.NextNode;
    //            else
    //                shouldMove = false;
    //        }
    //    }
    //}
}

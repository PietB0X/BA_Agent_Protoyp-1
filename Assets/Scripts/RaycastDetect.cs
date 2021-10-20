using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastDetect : MonoBehaviour
{
    public LayerMask layerMask;

    void Update()
    {
        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity, layerMask))
        {
            
            if (hit.collider.gameObject.tag == "Player")
            {
                Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
                Debug.Log("Hit " + hit.collider.gameObject.name);
            }
            else
            {
                Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.white);
                Debug.Log("Not Hit");
            }
        }
        else
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 1000, Color.white);
            Debug.Log("Not Hit");
        }

    }
}
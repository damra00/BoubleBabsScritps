using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public Vector3 offset,kayit;
    // Update is called once per frame
    void Update()
    {
        if (target)
        {
            kayit = target.position + offset;

        }
        else
            kayit = transform.position;
       
        transform.position = kayit;
    }
}

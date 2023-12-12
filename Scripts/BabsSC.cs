using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BabsSC : MonoBehaviour
{
    public Transform target;
    public Vector3 kayit;
    // Update is called once per frame
    void Update()
    {
        if (target)
        {
            kayit = target.position ;          
        }
        else
            kayit = transform.position;

        transform.position = kayit;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mizrak : MonoBehaviour
{
    public Rigidbody rb;
    public float speed, forgespeed;
    private bool timer;
    // Start is called before the first frame update
    void Start()
    {
        forgespeed = speed;
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = Vector3.down * forgespeed;
        if (timer)
        {
            if (forgespeed > 0)
            {
                forgespeed = -speed;
                timer = false;
            }
            else if (forgespeed < 0)
            {
                forgespeed = speed;
                timer = false;
            }
        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        if ((collision.gameObject.name == "MizrakEngel") || (collision.gameObject.name == "MizrakEngel1") || (collision.gameObject.name == "Zemin"))
        {
            timer = true;
        }
    }
}

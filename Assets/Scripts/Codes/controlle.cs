using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlle : MonoBehaviour
{
    public Rigidbody rb;
    public float forward = 10f;
    public float sideforce = 100f;
    

    

    // Update is called once per frame
    void Update()
    {

        rb.AddForce(0, 0, forward);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sideforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            

        }
        if (Input.GetKey("q"))
        {
            rb.AddForce(-sideforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

        }


    }
}

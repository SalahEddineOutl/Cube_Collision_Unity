using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForce : MonoBehaviour
{
    public Rigidbody rb;
    public float forward = 100f;
    bool ADD = false;
    public Transform Player;

    private void Update()
    {
        
        if (ADD == false )
        {
            ADD = true;
            rb.AddForce(forward, 0, 0, ForceMode.VelocityChange);
        }
    }
    void OnCollisionEnter(Collision collisioninfo)
    {
        
            
        

        if (collisioninfo.collider.tag == "ColliderX")
        {
            rb.AddForce(forward, 0, 0, ForceMode.VelocityChange);
        }
        if (collisioninfo.collider.tag == "ColliderY")
        {
            rb.AddForce(-forward, 0, 0, ForceMode.VelocityChange);
        }

    }
}

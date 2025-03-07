using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerbehavior : MonoBehaviour
{
    public float forwardforce = 100f;

    public Rigidbody rb;

    public float maxspeed = 1f;

    public float sidewaysforce = 500;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        rb.AddForce(0, 0, forwardforce * Time.deltaTime);

        if(rb.velocity.magnitude > maxspeed)
        {
            rb.velocity = rb.velocity.normalized * maxspeed;
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -2f)
        {
            FindObjectOfType<gamemanager>().Endgame();
        }
    }
}

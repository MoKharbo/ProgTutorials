using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    private Rigidbody rb;
    public float force = 15f;
    
    public float gravScaleUp = 1f;
    public float gravScaleDown = 2f;  
    private float originalGravity = -9.81f;
    public bool onFloor = false;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Floor")
        {
            onFloor = true;
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && onFloor == true)
        {
            rb.AddForce(Vector3.up * force, ForceMode.Impulse);
            onFloor = false;
        }

        if (rb.velocity.y < 0)
        {
            Physics.gravity = new Vector3(0, gravScaleUp * originalGravity, 0);
        }
        else if (rb.velocity.y > 0)
        {
            Physics.gravity = new Vector3(0, gravScaleDown * originalGravity, 0);
        }
        {

        }
    }
}

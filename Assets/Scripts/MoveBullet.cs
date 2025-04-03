using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBullet : MonoBehaviour
{
    public float speed = -2000f;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>(); 
    }

    void FixedUpdate()
    {
        rb.velocity = rb.transform.forward * Time.fixedDeltaTime * speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

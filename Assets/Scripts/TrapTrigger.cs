using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapTrigger : MonoBehaviour
{
    public GameObject ps;
    public float force = 200f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player") 
        {
            Rigidbody rb = other.GetComponent<Rigidbody>();
            Transform t = other.transform;

            rb.AddExplosionForce(force, new Vector3(t.position.x, t.position.y, t.position.z + 1f), 1f);

            Jump mbScript = other.GetComponentInParent<Jump>();
            mbScript.enabled = false;

            rb.constraints = RigidbodyConstraints.None;

            GameObject p = Instantiate(ps, transform);
            p.transform.position = t.position;

            Destroy(p, 2f);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

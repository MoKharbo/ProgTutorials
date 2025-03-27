using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetPickup : MonoBehaviour
{
    private Renderer r;
    private AudioSource source;
    private ParticleSystem ps;
    private KeepScore scoreScript;
    // Start is called before the first frame update
    void Start()
    {
        r = GetComponent<Renderer>();
        source = GetComponent<AudioSource>();
        ps = GetComponent<ParticleSystem>();
        ps.Stop();
        scoreScript = FindObjectOfType<KeepScore>();
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Player")
        {
            r.enabled = false;
            scoreScript.AddScore(1);
            source.Play();
            ps.Play();
            GameObject.Destroy(gameObject, 0.5f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animatie : MonoBehaviour
{
   
    private Animator ani;

    void Start()
    {
        
        ani = GetComponent<Animator>();
    }
    void Update()
    {
       
        if (Input.GetAxis("Vertical") > 0)
        {
            
            ani.SetTrigger("Walk");
            ani.ResetTrigger("Idle");
            ani.ResetTrigger("WalkR");
           
        }
        else if (Input.GetAxis("Vertical") < 0)
        {
           
            ani.SetTrigger("WalkR");
            ani.ResetTrigger("Idle");
            ani.ResetTrigger("Walk");
        }
        else
        {
          
            ani.SetTrigger("Idle");
            ani.ResetTrigger("Walk");
            ani.ResetTrigger("WalkR");
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAnimation : MonoBehaviour
{
    public float delay = 3f;
    public float resetTime;
    public KeyCode triggerKey = KeyCode.None;
    private bool canAttack = false;

    public Animator animator;
    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();  
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(triggerKey))
        {
            CallTrigger();
        }

        if (canAttack)
        {
            animator.SetBool("Attack", true);
        }
        else
        {
            animator.SetBool("Attack", false);
        }
    }
    public void CallTrigger()
    {
        StartCoroutine(TriggerSequence());
    }
    private IEnumerator AwaitDelay(float time)
    {
        yield return new WaitForSeconds(time);
        canAttack = true;
        if (audioSource != null) audioSource.Play();
    }
    private IEnumerator AwaitReset(float time)
    {
        yield return new WaitForSeconds(time);
        canAttack = false;
    }

    private IEnumerator TriggerSequence()
    {
        yield return new WaitForSeconds(delay);
        canAttack = true;
        if (audioSource != null) audioSource.Play();
        yield return new WaitForSeconds(resetTime);
        canAttack = false;
    }

}

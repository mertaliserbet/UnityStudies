using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimations : MonoBehaviour
{
    private Animator animator;
    public float moveSpeed = 5;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            animator.SetBool("isWalking", true);
            animator.SetBool("isJumping", false);
            animator.SetBool("isRunning", false);

            transform.position += transform.forward * moveSpeed * Time.deltaTime;

        }else if (Input.GetKey(KeyCode.S))
        {
            animator.SetBool("isWalking", true);
            animator.SetBool("isJumping", false);
            animator.SetBool("isRunning", false);

            transform.position -= transform.forward * moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.Space))
        { 
            animator.SetBool("isWalking", false);
            animator.SetBool("isJumping", true);
            animator.SetBool("isRunning", false);

            
        }





        }
}

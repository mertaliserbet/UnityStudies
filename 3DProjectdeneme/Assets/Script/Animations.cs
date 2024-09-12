using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Animations : MonoBehaviour
{
    private Animator animator;
    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            animator.SetBool("isScale", true);
        }
        else if (Input.GetKey(KeyCode.Q))
        {
            animator.SetBool("isScale", false);
        }
        
    }
}

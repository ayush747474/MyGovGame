using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Animator animator; 
    public float PlayerSpeed = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xInput = Input.GetAxis("Horizontal");
        transform.Translate(xInput*PlayerSpeed, 0f, 0f);
        animator.SetFloat("Speed", xInput);
    }
}

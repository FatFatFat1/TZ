using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour
{
    float gravity;
    private Animator anim;
    void Start()
    {
        gravity = GetComponent<Rigidbody2D>().gravityScale;
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            gravity = -gravity;
            GetComponent<Rigidbody2D>().gravityScale = gravity;
            anim.SetBool("IsJump", true);
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            gravity = -gravity;
            GetComponent<Rigidbody2D>().gravityScale = gravity;
            anim.SetBool("IsJump", false);
        }
    }
}

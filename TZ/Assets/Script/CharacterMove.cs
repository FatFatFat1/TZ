using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour
{
    private Animator anim;
    public Rigidbody2D player;
    private float thrust = 10.0f;
    void Start()
    {
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            player.AddForce(transform.up * thrust,ForceMode2D.Impulse);
            anim.SetBool("IsJump", true);
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            anim.SetBool("IsJump", false);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour
{
    private Animator anim;
    public Rigidbody2D player;
    void Start()
    {
        anim = GetComponent<Animator>();
    }
    void Update()
    {
#if UNITY_STANDALONE
        if (Input.GetKeyDown(KeyCode.Space))
        {
            player.AddForce(transform.up * 10.0f, ForceMode2D.Impulse);
            anim.SetBool("IsJump", true);
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            anim.SetBool("IsJump", false);
        }
#elif UNITY_IOS || UNITY_ANDROID
         if(Input.touchCount > 0)
         {
            Touch myTouch =  Input.GetTouch(0);
            if(myTouch.phase == TouchPhase.Began)
             {
                player.AddForce(transform.up * 10.0f, ForceMode2D.Impulse);
                anim.SetBool("IsJump", true);
             }
             if(myTouch.phase == TouchPhase.Ended)
             {
                anim.SetBool("IsJump", false);
             }

         }
#endif

    }
}

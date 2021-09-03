using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MajorMove : MonoBehaviour
{
    private GameObject player;
    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
    void Update()
    {  
        if(GetComponent<Transform>().position.x < -15)
        {
            Destroy(gameObject); //За военкоматом нет жизни
        }
        if(player.GetComponent<Fail>().IsLose != true)
        {
            transform.position -= transform.right * Time.deltaTime * 2;
        }
    }
}

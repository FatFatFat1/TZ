using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MajorMove : MonoBehaviour
{
    void Update()
    {
        transform.position -= transform.right * Time.deltaTime*2;
        if(GetComponent<Transform>().position.x < -15)
        {
            Destroy(gameObject); //За военкоматом нет жизни
        }
    }
}

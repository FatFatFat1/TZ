using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScopeAdd : MonoBehaviour
{
    GameObject scopeZone;
    private GameObject player;
    public GameObject canvas;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Вошло");
    }

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

}

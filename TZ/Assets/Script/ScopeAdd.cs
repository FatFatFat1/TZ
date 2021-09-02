using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScopeAdd : MonoBehaviour
{
    GameObject scopeZone;
    private GameObject player;
    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        int scope = player.GetComponent<ScopeData>().scope;
        scope += 1;
        player.GetComponent<ScopeData>().scope = scope;
    }
}

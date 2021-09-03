using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScopeAdd : MonoBehaviour
{
    private GameObject player;
    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        int record = player.GetComponent<ScopeData>().record;
        int scope = player.GetComponent<ScopeData>().scope;
        scope += 1;
        if (scope > record)
        {
            player.GetComponent<ScopeData>().record = scope;
        }
        player.GetComponent<ScopeData>().scope = scope;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fail : MonoBehaviour
{
    public GameObject player;
    public GameObject board;
    public GameObject failBoard;
    public GameObject failScreen;

    [System.Obsolete]
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag != "ScopeZone")
        {
            board.active = false;
            failBoard.active = true;
            failScreen.GetComponent<Text>().text = player.GetComponent<ScopeData>().scope.ToString();
        }
    }
}

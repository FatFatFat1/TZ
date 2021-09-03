using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fail : MonoBehaviour
{
    public GameObject player;
    public GameObject board; // Канвас с очками
    public GameObject failBoard; //Канвас проигрыша
    public GameObject failScreen; // Text с кол-вом набранным очков в failBoard
    public GameObject floor; // для того чтобы отключать анимацию движения полу
    public bool IsLose=false;

    [System.Obsolete]
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag != "ScopeZone")
        {
            board.active = false;
            failBoard.active = true;
            IsLose = true;
            failScreen.GetComponent<Text>().text = player.GetComponent<ScopeData>().scope.ToString();
            floor.GetComponent<Animator>().SetBool("IsLose", true);
        }
    }
}

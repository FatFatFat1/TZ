using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
/// <summary>
/// Скрипт постановки игры на паузу
/// </summary>
public class Pause : MonoBehaviour
{
    /// <summary>
    /// То что мы присваем для Time.timeScale
    /// </summary>
    public float Timer;
    /// <summary>
    /// Стоит ли пауза?
    /// </summary>
    public bool IsPause = false;
    /// <summary>
    /// Для того чтобы запретить игроку перемещаться (я не знаю как он сквозь паузу все равно прыгает)
    /// </summary>
    public void PausePressed()
    {
        IsPause = !IsPause;
        if (IsPause)
        {
            Timer = 0;
            CharacterMove.IsPause = true;
        }
        else if (!IsPause)
        {
            Timer = 1f;
            CharacterMove.IsPause = false;
        }
        Time.timeScale = Timer;
    }
}

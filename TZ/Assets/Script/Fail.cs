using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// То что происходит при поражении игрока
/// </summary>
public class Fail : MonoBehaviour
{
    #region Public Fields

    /// <summary>
    /// Канвас с текущими очками игрока до поражения
    /// </summary>
    public GameObject Board;

    /// <summary>
    /// Канвас проигрыша
    /// </summary>
    public GameObject FailBoard;

    /// <summary>
    /// Текст куда записываются очки
    /// </summary>
    public GameObject FailScreen;

    /// <summary>
    /// Пол чтобы останавливать анимацию ему
    /// </summary>
    public GameObject Floor;

    /// <summary>
    /// Факт поражения игрока
    /// </summary>
    public bool IsLose = false;

    public GameObject Player;

    #endregion Public Fields

    #region Private Methods

    [System.Obsolete]
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag != "ScopeZone")
        {
            Board.active = false;
            FailBoard.active = true;
            IsLose = true;
            FailScreen.GetComponent<Text>().text = Player.GetComponent<ScopeData>().Scope.ToString();
            Floor.GetComponent<Animator>().SetBool("IsLose", true);
        }
    }

    #endregion Private Methods
}
using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// Обновление очков и рекордов
/// </summary>
public class ScopeData : MonoBehaviour
{
    #region Public Fields

    /// <summary>
    /// Рекорд
    /// </summary>
    public int Record;

    /// <summary>
    /// То куда записывается рекорд
    /// </summary>
    public GameObject RecordBoard;

    /// <summary>
    /// Текущие очки игрока
    /// </summary>
    public int Scope;

    /// <summary>
    /// То куда записываются очки
    /// </summary>
    public GameObject ScopeBoard;

    #endregion Public Fields

    #region Private Methods

    private void Update()
    {
        ScopeBoard.GetComponent<Text>().text = Scope.ToString();
        RecordBoard.GetComponent<Text>().text = Record.ToString();
    }

    #endregion Private Methods
}
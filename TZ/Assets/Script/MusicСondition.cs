using UnityEngine;

/// <summary>
/// Включение или Отключение Источника музыки,в зависимости от состояния MusicСondition из MyVariable
/// </summary>
public class MusicСondition : MonoBehaviour
{
    #region Public Fields

    /// <summary>
    /// Источник музыки
    /// </summary>
    public GameObject SoundSource;

    #endregion Public Fields

    #region Private Fields

    /// <summary>
    /// Играет ли сейчас музыка
    /// </summary>
    private bool _isMusicPlay;

    #endregion Private Fields

    #region Private Methods

    private void Awake()
    {
        _isMusicPlay = MyVariable.MusicСondition;
    }

    private void Start()
    {
        if (!_isMusicPlay)
        {
            SoundSource.SetActive(false);
        }
    }

    #endregion Private Methods
}
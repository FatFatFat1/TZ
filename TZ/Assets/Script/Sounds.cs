using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

/// <summary>
/// Настройка звука (вкл/выкл)
/// </summary>
public class Sounds : MonoBehaviour
{
    #region Public Fields

    /// <summary>
    /// Включена ли сейчас музыка
    /// </summary>
    static public bool IsMusic = true;

    /// <summary>
    /// Кнопка которй меняем цвет в зависимости от состояния IsMusic
    /// </summary>
    public GameObject Sound;

    #endregion Public Fields

    #region Public Methods

    public void MainMenuPressed()
    {
        SceneManager.LoadScene("Main Menu");
        SceneManager.UnloadSceneAsync("Sound");
    }

    public void SoundPressed()
    {
        IsMusic = !IsMusic;
        if (IsMusic)
        {
            Sound.GetComponent<Image>().color = Color.green;
        }
        else
        {
            Sound.GetComponent<Image>().color = Color.red;
        }
        Debug.Log(IsMusic);
    }

    #endregion Public Methods

    #region Private Methods

    private void OnDestroy()
    {
        MyVariable.MusicСondition = IsMusic;
    }

    #endregion Private Methods
}
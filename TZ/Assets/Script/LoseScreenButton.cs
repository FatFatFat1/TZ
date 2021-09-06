using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Переход в главное меню при поражении
/// </summary>
public class LoseScreenButton : MonoBehaviour
{
    #region Public Methods

    public void QuitGamePressed()
    {
        SceneManager.LoadScene("Main Menu");
        SceneManager.UnloadSceneAsync("SampleScene");
    }

    #endregion Public Methods
}
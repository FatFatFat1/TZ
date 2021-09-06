using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Логика меню
/// </summary>
public class MainMenu : MonoBehaviour
{
    #region Public Methods

    public void ExitPressed()
    {
        Application.Quit();
    }

    public void PlayPressed()
    {
        SceneManager.LoadScene("SampleScene");
        SceneManager.UnloadSceneAsync("Main Menu");
    }

    public void QuitGamePressed()
    {
        SceneManager.LoadScene("Main Menu");
        SceneManager.UnloadSceneAsync("SampleScene");
    }

    public void SoundPressed()
    {
        SceneManager.LoadScene("Sound");
        SceneManager.UnloadSceneAsync("Main Menu");
    }

    #endregion Public Methods
}
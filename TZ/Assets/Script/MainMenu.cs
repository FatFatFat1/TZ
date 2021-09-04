using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayPressed()
    {
        SceneManager.LoadScene("SampleScene");
        SceneManager.UnloadSceneAsync("Main Menu");
    }

    public void ExitPressed()
    {
        Application.Quit();
    }
    public void QuitGamePressed()
    {
        SceneManager.LoadScene("Main Menu");
        SceneManager.UnloadSceneAsync("SampleScene");
    }

}

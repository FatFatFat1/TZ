using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseScreenButton : MonoBehaviour
{
    public void QuitGamePressed()
    {
        SceneManager.LoadScene("Main Menu");
        SceneManager.UnloadSceneAsync("SampleScene");
    }

}

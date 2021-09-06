using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Sounds : MonoBehaviour
{
    static public bool music = true;
    public GameObject sounds;
    public void SoundPressed()
    {
        music = !music;
        if (music)
        {
            sounds.GetComponent<Image>().color = Color.green;
        }
        else
        {
            sounds.GetComponent<Image>().color = Color.red;
        }
        Debug.Log(music);
    }
    public void MainMenuPressed()
    {
        SceneManager.LoadScene("Main Menu");
        SceneManager.UnloadSceneAsync("Sound");
    }
    private void OnDestroy()
    {
        MyVariable.musicСondition = music;
    }
}

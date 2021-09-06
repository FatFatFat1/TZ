using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
using System;

public class MainMenuRecord : MonoBehaviour
{
    public GameObject scopeText;
    private void Awake()
    {
        using (FileStream recordSave = new FileStream(Application.dataPath + "/record.txt", FileMode.Open))
        {
            byte[] array = new byte[recordSave.Length];
            recordSave.Read(array, 0, array.Length);
            string textFromFile = System.Text.Encoding.Default.GetString(array);
            scopeText.GetComponent<Text>().text = textFromFile;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class ScopeData : MonoBehaviour
{
    public int scope;
    public int record;
    public GameObject scopeBoard;
    public GameObject recordBoard;
    string path = @"D:\FlappyBird\TZ\TZ\Assets\Script\record.txt";
    private void Update()
    {
        scopeBoard.GetComponent<Text>().text = scope.ToString();
        recordBoard.GetComponent<Text>().text = record.ToString();
        using (FileStream recordSave = new FileStream(path, FileMode.Open))
        {
            byte[] array = new byte[recordSave.Length];
            recordSave.Read(array, 0, array.Length);
            string textFromFile = System.Text.Encoding.Default.GetString(array);
            //Debug.Log(($"Текст из файла: {textFromFile}"));
        }
    }
}

using System.IO;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Чтение файла рекорда для рекорда в главном меню
/// </summary>
public class MainMenuRecord : MonoBehaviour
{
    #region Public Fields

    /// <summary>
    /// Канвас который содержит рекорд в главном меню
    /// </summary>
    public GameObject ScopeText;

    #endregion Public Fields

    #region Private Methods

    private void Awake()
    {
        using (FileStream recordSave = new FileStream(Application.dataPath + "/record.txt", FileMode.Open))
        {
            byte[] array = new byte[recordSave.Length];
            recordSave.Read(array, 0, array.Length);
            string textFromFile = System.Text.Encoding.Default.GetString(array);
            ScopeText.GetComponent<Text>().text = textFromFile;
        }
    }

    #endregion Private Methods
}
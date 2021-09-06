using System;
using System.IO;
using UnityEngine;
/// <summary>
/// Добавление очков по тригеру коллайдера и чтение рекорда из файла рекордов
/// </summary>
public class ScopeAdd : MonoBehaviour
{
    #region Private Fields

    /// <summary>
    /// Игрок
    /// </summary>
    private GameObject _player;

    /// <summary>
    /// Рекорд игрока
    /// </summary>
    private int _record;

    /// <summary>
    /// Текущие очки игрока
    /// </summary>
    private int _scope;

    #endregion Private Fields

    #region Private Methods

    private void Awake()
    {
        _player = GameObject.FindGameObjectWithTag("Player");
        //Чтение рекорда из файла
        using (FileStream recordSave = new FileStream(Application.dataPath + "/record.txt", FileMode.Open))
        {
            byte[] array = new byte[recordSave.Length];
            recordSave.Read(array, 0, array.Length);
            string textFromFile = System.Text.Encoding.Default.GetString(array);
            _record = Convert.ToInt32(textFromFile);
            _player.GetComponent<ScopeData>().Record = _record;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        _scope = _player.GetComponent<ScopeData>().Scope;
        _scope += 1;
        if (_scope > _record)
        {
            //Запись нового рекорда
            _player.GetComponent<ScopeData>().Record = _scope;
            using (FileStream recordSave = new FileStream(Application.dataPath + "/record.txt", FileMode.OpenOrCreate))
            {
                byte[] array = System.Text.Encoding.Default.GetBytes(_scope.ToString());
                recordSave.Write(array, 0, array.Length);
            }
        }
        _player.GetComponent<ScopeData>().Scope = _scope;
    }

    #endregion Private Methods
}
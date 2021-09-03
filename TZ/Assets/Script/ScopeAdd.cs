﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;

public class ScopeAdd : MonoBehaviour
{
    private GameObject player;
    int record;
    int scope;
    string path = @"D:\FlappyBird\TZ\TZ\Assets\Script\record.txt";
    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        using (FileStream recordSave = new FileStream(path, FileMode.Open))
        {
            byte[] array = new byte[recordSave.Length];
            recordSave.Read(array, 0, array.Length);
            string textFromFile = System.Text.Encoding.Default.GetString(array);
            record = Convert.ToInt32(textFromFile);
            player.GetComponent<ScopeData>().record = record;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        scope = player.GetComponent<ScopeData>().scope;
        scope += 1;
        if (scope > record)
        {
            player.GetComponent<ScopeData>().record = scope;
            using (FileStream recordSave = new FileStream(path, FileMode.OpenOrCreate))
            {
                byte[] array = System.Text.Encoding.Default.GetBytes(scope.ToString());
                recordSave.Write(array, 0, array.Length);
            }
        }
        player.GetComponent<ScopeData>().scope = scope;
    }
}

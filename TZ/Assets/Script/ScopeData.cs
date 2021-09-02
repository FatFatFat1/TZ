using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScopeData : MonoBehaviour
{
    public int scope;
    public GameObject canvas;
    private void Update()
    {
        canvas.GetComponent<Text>().text = scope.ToString();
    }
}

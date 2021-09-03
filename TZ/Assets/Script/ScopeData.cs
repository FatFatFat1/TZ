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
    private void Update()
    {
        scopeBoard.GetComponent<Text>().text = scope.ToString();
        recordBoard.GetComponent<Text>().text = record.ToString();
    }
}

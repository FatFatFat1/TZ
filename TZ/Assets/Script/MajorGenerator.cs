using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MajorGenerator : MonoBehaviour
{
    public GameObject major;
    Vector2 point;
    Vector2 difference = new Vector2(0,4);
    void Generation(Vector2 point)
    {
        Instantiate(major, point - difference, Quaternion.identity);
        Instantiate(major, point + difference, Quaternion.identity);
    }
    private void Start()
    {
        point = new Vector2(10,Random.Range(0,3));
        Generation(point);
    }
}

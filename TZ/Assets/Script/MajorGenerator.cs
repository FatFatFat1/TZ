using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MajorGenerator : MonoBehaviour
{
    public GameObject major;
    Vector2 point;
    Vector2 difference = new Vector2(0,4);
    float time = 3; // Раз всколько секунд нужно рожать майоров.
    void Generation(Vector2 point)
    {
        Instantiate(major, point - difference, Quaternion.identity);
        Instantiate(major, point + difference, Quaternion.identity);
    }

    private void Update()
    {
            time -= Time.deltaTime;
        if (time <= 0) 
        {
            point = new Vector2(20, Random.Range(0, 3));
            Generation(point);
            time = 3;
        }
    }
}

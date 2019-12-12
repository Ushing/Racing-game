using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstracleCarGenerator : MonoBehaviour
{
    public GameObject obstracleCar;
    public GameObject[] obstracleCars;

    void Start()
    {
        InvokeRepeating("GeneratorObstacleCars", 1f, 5f);
    }

  
    void Update()
    {
        
    }
    private void GeneratorObstacleCars()
    {
        int randomNum = Random.Range(0, 2);
        if (randomNum == 0)
        {
            Instantiate(obstracleCars[Random.Range(0, obstracleCars.Length)], new Vector2(-5f, 24f), Quaternion.identity);
        }
        else
        {
            Instantiate(obstracleCars[Random.Range(0, obstracleCars.Length)], new Vector2(5f, 24f), Quaternion.identity);
        }
    }
}

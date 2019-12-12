using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstracle_Car : MonoBehaviour
{

    public float moveSpeed = 1f;
    void Start()
    {
        
    }

    
    void Update()
    {
        transform.Translate(-transform.up * Time.deltaTime * moveSpeed);
    }
}

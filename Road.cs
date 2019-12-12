using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Road : MonoBehaviour
{
    public GameObject plane;

    private Renderer planeRenderer;

    public float speed = 1f;

    public Vector2 offset;

    void Start()
    {
        planeRenderer = plane.GetComponent<Renderer> ();
    }

    
    void Update()
    {
        offset.y += -speed * Time.deltaTime;
        planeRenderer.material.SetTextureOffset("_MainTex",offset);
    }
}

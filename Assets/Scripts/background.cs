using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class background : MonoBehaviour
{

    MeshRenderer meshrenderer;
    
    void Start()
    {
        meshrenderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float speed = 0.0001f;
        meshrenderer.material.mainTextureOffset += Vector2.right * speed;
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject block;
    public float minspawnRate = 1;
    public float maxspawnRate = 2;
    public float minHeight = -5f;
    public float maxHeight = 5f;



    void OnEnable()
    {
        InvokeRepeating(nameof(Spawn), 1, UnityEngine.Random.Range(minspawnRate,maxspawnRate));
    }

    void OnDisable()
    {
        CancelInvoke(nameof(Spawn));
    }


    void Spawn()
    {
        GameObject obstacles = Instantiate(block, transform.position, Quaternion.identity);
        obstacles.transform.position += Vector3.up * UnityEngine.Random.Range(minHeight, maxHeight);
    }
}

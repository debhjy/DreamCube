using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blocks : MonoBehaviour

{

    public float initialspeed = 5f;
    
    private float edgeLeft;

    // Start is called before the first frame update
    void Start()
    {
        edgeLeft = Camera.main.ScreenToWorldPoint(Vector3.zero).x -1f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * initialspeed * Time.deltaTime;
        

        if (transform.position.x < edgeLeft)
        {
            Destroy(gameObject);
        }
    }
}

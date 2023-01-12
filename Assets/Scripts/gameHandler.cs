using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameHandler : MonoBehaviour
{
    public static gameHandler Instance { get; private set; }

    private player player;
    private spawner spawner;
    public Button retry;

    private void Awake()
    {
        if (Instance != null)
        {
            DestroyImmediate(gameObject);
        }
        else
        {
            Instance = this;
        }
    }

    private void OnDestroy()
    {
        if (Instance == this)
        {
            Instance = null;
        }
    }

    void Start()
    {
        blocks[] blocks = FindObjectsOfType<blocks>();

        foreach (var block in blocks)
        {
            Destroy(block.gameObject);
        }
        

        player = FindObjectOfType<player>();
        spawner = FindObjectOfType<spawner>();

        NewGame();
    }



    public void GameOver()
    {
        Debug.Log("Game Over");
       player.gameObject.SetActive(false);
        
        spawner.gameObject.SetActive(false);
        retry.gameObject.SetActive(true);
        enabled = false;
        
    }

    public void NewGame()
    {
        player.transform.position = new Vector2(-3.91f, -3.05f);
        enabled = true;
        player.gameObject.SetActive(true);
        spawner.gameObject.SetActive(true);
        retry.gameObject.SetActive(false);
    }
}

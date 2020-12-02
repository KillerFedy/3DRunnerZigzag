using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private UImanager _uIManager;
    public int Coin { get; private set; }
    public float GameTime { get; private set; }

    private void Start()
    {
        Coin = 0;
    }

    private void Update()
    {
        GameTime += Time.deltaTime;
    }

    public void AddCoin()
    {
        Coin++;
        _uIManager.UpdateCoinText();
    }
    
    public void ReplyGame()
    {
        SceneManager.LoadScene(0);
        GameTime = 0;
    }
}

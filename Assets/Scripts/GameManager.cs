using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private UImanager _uIManager;
    public int Coin { get; private set; }
    
    private void Start()
    {
        Coin = 0;
    }

    public void AddCoin()
    {
        Coin++;
        _uIManager.UpdateCoinText();
    }
    
    public void ReplyGame()
    {
        SceneManager.LoadScene(0);
    }
}

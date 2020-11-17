using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int Coin { get; private set; }
    
    private void Start()
    {
        Coin = 0;
    }

    public void AddCoin()
    {
        Coin++;
    }
    
    public void ReplyGame()
    {
        SceneManager.LoadScene(0);
    }
}

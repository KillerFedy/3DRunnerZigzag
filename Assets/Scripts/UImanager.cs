using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UImanager : MonoBehaviour
{
    [SerializeField] private Text _score;
    [SerializeField] private Text _finalScore;
    [SerializeField] private GameObject _finalPanel;
    [SerializeField] private GameManager _gameManager;
    
    public void UpdateCoinText()
    {
        _score.text = _gameManager.Coin.ToString();
    }
    public void OnPlayerDeath()
    {
        _finalPanel.SetActive(true);
        _finalScore.text = _gameManager.Coin.ToString();
    }
}

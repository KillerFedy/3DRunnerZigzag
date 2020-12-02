using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Road : MonoBehaviour
{
    [SerializeField] private Block _cube;
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private GameManager _gameManager;
    
    private Vector3 _lastPosition = new Vector3(0, -1, 0);
    private List<Vector3> _directionRoad = new List<Vector3>() { new Vector3(1, 0, 0),  new Vector3(0, 0, 1)};

    private void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            StartCoroutine(CreateNewBlock(0));
        }
        StartCoroutine(CreateNewBlock(0.2f));
    }
    
    private IEnumerator CreateNewBlock(float time)
    {
        yield return new WaitForSeconds(time);
        SetBlockDirection();
        if (_playerTransform != null)
        {
            var block = Instantiate(_cube, _lastPosition, Quaternion.identity);
            block.Init(_playerTransform, transform);
            if (time != 0)
            {
                StartCoroutine(CreateNewBlock(0.2f));
            }
        }
    }

    private void SetBlockDirection()
    {
        Vector3 direction = new Vector3(1,0,0);
        if (_gameManager.GameTime > 3)
        {
            int numberOfListDirections = Random.Range(0, 2);
            direction = _directionRoad[numberOfListDirections];   
        }
        _lastPosition += direction;
    }
}

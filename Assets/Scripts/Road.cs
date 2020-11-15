using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Road : MonoBehaviour
{
    [SerializeField] private Block _cube;
    [SerializeField] private Transform _playerTransform;
    
    private Vector3 _lastPosition = new Vector3(0, -1, 0);
    private List<Vector3> _directionRoad = new List<Vector3>() { new Vector3(1, 0, 0),  new Vector3(0, 0, 1)};
    
    private void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            CreateNewBlock(new Vector3(1,0,0));
        }
        InvokeRepeating("CreateNewBlock", 1, 0.2f);
    }
    
    private void CreateNewBlock()
    {
        int numberOfListDirections = Random.Range(0, 2);
        _lastPosition += _directionRoad[numberOfListDirections];
        var block = Instantiate(_cube, _lastPosition, Quaternion.identity);
        block.Init(_playerTransform, transform);
    }

    private void CreateNewBlock(Vector3 direction)
    {
        _lastPosition += direction;
        var block =  Instantiate(_cube, _lastPosition, Quaternion.identity);
        block.Init(_playerTransform, transform);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Road : MonoBehaviour
{
    [SerializeField] private GameObject _cube;
    private Vector3 _lastPosition = new Vector3(0, -1, 0);
    private List<Vector3> _directionRoad = new List<Vector3>() { new Vector3(1, 0, 0),  new Vector3(0, 0, 1)};
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            _lastPosition += new Vector3(1, 0, 0);
            Instantiate(_cube, _lastPosition, Quaternion.identity);
        }
    }
    
    void Update()
    {
        int numberOfListDirections = Random.Range(0, 2);
        _lastPosition += _directionRoad[numberOfListDirections];
        Instantiate(_cube, _lastPosition, Quaternion.identity);
    }
}

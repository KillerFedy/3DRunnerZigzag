using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private Transform _blockParent;

    private void Update()
    {
        if (transform.position.x < _playerTransform.position.x || transform.position.z < _playerTransform.position.z)
        {
            Destroy(gameObject, 5);
        }
    }

    public void Init(Transform player, Transform parent)
    {
        _playerTransform = player;
        transform.parent = parent;
    }
}

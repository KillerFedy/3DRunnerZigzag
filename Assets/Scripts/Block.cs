using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Block : MonoBehaviour
{
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private Transform _blockParent;
    [SerializeField] private GameObject _crystall;
    
    private Quaternion _startRotationCrystall = Quaternion.Euler(90, 0, 180);

    private void Start()
    {
        int isCreateCrystall = Random.Range(0, 6);
        Vector3 createPosition = transform.position + new Vector3(0, 1.2f, 0);
        if (isCreateCrystall == 4)
        {
            GameObject obj = Instantiate(_crystall, createPosition, _startRotationCrystall);
            obj.transform.parent = transform;
        }
    }

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

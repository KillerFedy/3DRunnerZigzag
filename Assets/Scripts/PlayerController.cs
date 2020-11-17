using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private UImanager _uImanager;
    [SerializeField] private GameManager _gameManager;
    
    private Rigidbody _playerRigidbody;
    private float _speed = 5f; 
    private bool _isMovingRight = true;
    // Start is called before the first frame update
    private void Start()
    {
        _playerRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ChangeDirection();   
        }
        if (_isMovingRight)
        {
            _playerRigidbody.velocity = new Vector3 (_speed, _playerRigidbody.velocity.y, 0f);
        } 
        else {
            _playerRigidbody.velocity = new Vector3 (0f, _playerRigidbody.velocity.y, _speed);
        }

        if (transform.position.y < -3)
        {
            Dead();
        }

    }
    private void ChangeDirection()
    {
        _isMovingRight =  !_isMovingRight;
    }

    private void Dead()
    {
        _uImanager.OnPlayerDeath();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Crystall")
        {
            _gameManager.AddCoin();
            Destroy(other.gameObject);
        }
    }
}
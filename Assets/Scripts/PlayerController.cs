using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody _playerRigidbody;
    private float _speed = 5f; 
    private bool _isMovingRight = true;
    // Start is called before the first frame update
    private void Start()
    {
        _playerRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ChangeDirection();   
        }
        if (_isMovingRight) {
            //_playerRigidbody.AddForce(new Vector3 (_speed, 0f, 0f));
            transform.Translate(new Vector3 (_speed, 0f, 0f) * Time.fixedDeltaTime);
            //_playerRigidbody.velocity = new Vector3 (_speed, 0f, 0f);
        } 
        else {
            //_playerRigidbody.AddForce(new Vector3 (0, 0f, _speed));
            transform.Translate(new Vector3 (0f, 0f, _speed) * Time.fixedDeltaTime);
            //_playerRigidbody.velocity = new Vector3 (0f, 0f, _speed);
        }

    }
    void ChangeDirection()
    {
        _isMovingRight =  !_isMovingRight;
    }

}
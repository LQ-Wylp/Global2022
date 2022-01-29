using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float _speed;
    public float _jumpForce;

    private float _moveInput;
    private Rigidbody2D _rb;

    private bool _isGrounded;
    public Transform _groundCheck;
    public float _checkRadius;
    public LayerMask _whatIsGrounded;

    private bool _lookAtRight = true;

    private int extraJumps;
    public int extraJumpsValue;

    void Start()
    {
        extraJumps = extraJumpsValue;
        _rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if(_isGrounded == true)
        {
            extraJumps = extraJumpsValue;
        }

        if(Input.GetKeyDown(KeyCode.Space) && extraJumps > 0)
        {
            _rb.velocity = Vector2.up * _jumpForce;
            extraJumps --;
        }
        else if(Input.GetKeyDown(KeyCode.Space) && extraJumps == 0 && _isGrounded)
        {
            _rb.velocity = Vector2.up * _jumpForce;
        }
    }

    void FixedUpdate()
    {
        _isGrounded = Physics2D.OverlapCircle(_groundCheck.position,_checkRadius, _whatIsGrounded);

        _moveInput = Input.GetAxis("Horizontal");
        _rb.velocity = new Vector2(_moveInput * _speed, _rb.velocity.y);

        if(_lookAtRight == false && _moveInput > 0)
        {
            Flip();
        }

        else if(_lookAtRight == true && _moveInput < 0)
        {
            Flip();
        }
    }

    void Flip()
    {
        _lookAtRight = !_lookAtRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
    }

    public void ResetVelocity()
    {
        _rb.velocity = Vector3.zero;
    }

    
}

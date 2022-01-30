using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float _speed;

    public float _coefSpeed;
    public float _jumpForce;
    public Animator animator;

    private float _moveInput;
    private Rigidbody2D _rb;

    private bool _isGrounded;
    public Transform _groundCheck;
    public float _checkRadius;
    public LayerMask _whatIsGrounded;

    private bool _lookAtRight = true;

    private int extraJumps;
    public int extraJumpsValue;

    public bool _InverseControls = false;

    private float _gravityScaleInitial;

    void Start()
    {
        _coefSpeed = 1;
        extraJumps = extraJumpsValue;
        _rb = GetComponent<Rigidbody2D>();

        _gravityScaleInitial = _rb.gravityScale;
        
    }

    void Update()
    {
        if(_isGrounded == true)
        {
            extraJumps = extraJumpsValue;
            animator.SetBool("Jump", false);
        }

        if(Input.GetKeyDown(KeyCode.Space) && extraJumps > 0)
        {
            animator.SetBool("Jump", true);
            _rb.velocity = Vector2.up * _jumpForce;
            extraJumps --;
        }
        else if(Input.GetKeyDown(KeyCode.Space) && extraJumps == 0 && _isGrounded)
        {
            animator.SetBool("Jump", true);
            _rb.velocity = Vector2.up * _jumpForce;
        }
    }

    void FixedUpdate()
    {
        _isGrounded = Physics2D.OverlapCircle(_groundCheck.position,_checkRadius, _whatIsGrounded);

        _moveInput = Input.GetAxis("Horizontal");
        if (_moveInput > 0 || _moveInput < 0) animator.SetBool("Walk", true);
        else animator.SetBool( "Walk" , false);

        if(_InverseControls)
        {
            _rb.velocity = new Vector2(-_moveInput * _speed, _rb.velocity.y);
        }
        else
        {
            _rb.velocity = new Vector2(_moveInput * _speed, _rb.velocity.y);
        }

        if(_lookAtRight == false && _moveInput > 0)
        {
            Flip();
        }

        else if(_lookAtRight == true && _moveInput < 0)
        {
            Flip();
        }

        _rb.gravityScale = _gravityScaleInitial;
        _rb.velocity = new Vector2( _rb.velocity.x * _coefSpeed, _rb.velocity.y);
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

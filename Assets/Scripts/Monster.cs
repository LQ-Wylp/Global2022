using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    public bool _Pathed;
    private Transform _pointA;
    private Transform _pointB;
    public float _speed;
    public float _fallSpeed;

    private float pourcentage;
    private int Etat = 0;

    private bool _lookAtRight = false;

    void Update()
    {
        if(_Pathed && _pointA != null && _pointB != null)
        {
            if(Etat == 0)
            {
                pourcentage += _speed * Time.deltaTime / Vector3.Distance(transform.position,_pointA.position);
                transform.position = Vector3.Lerp(transform.position, _pointA.position, pourcentage);
                if(pourcentage >= 1)
                {
                    pourcentage = 0;
                    Etat = 1;
                }

                if (_lookAtRight == false)
                {
                    Flip();
                }
            }
            if(Etat == 1)
            {
                pourcentage += _speed * Time.deltaTime / Vector3.Distance(transform.position,_pointB.position);
                transform.position = Vector3.Lerp(transform.position, _pointB.position, pourcentage);
                if(pourcentage >= 1)
                {
                    pourcentage = 0;
                    Etat = 0;
                }

                if (_lookAtRight == true)
                {
                    Flip();
                }
            }
        }
        else
        {
            transform.position = new Vector3(transform.position.x,transform.position.y  - _fallSpeed * Time.deltaTime, transform.position.z);
        }
    }
    void Flip()
    {
        _lookAtRight = !_lookAtRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Walked")
        {
            _pointA = other.gameObject.GetComponent<WalkedMonster>().pointA;
            _pointB = other.gameObject.GetComponent<WalkedMonster>().pointB;
            _Pathed = true;
        }

        if(other.tag == "Player")
        {
            other.gameObject.GetComponent<PlayerCheckpoint>().Respawn();
        }
    }
}

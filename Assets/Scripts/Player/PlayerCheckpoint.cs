using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCheckpoint : MonoBehaviour
{
    public Transform _Respawn;
    private Vector3 _PosInitial;
    private Move _Move;
    private PlayerHealth _PlayerHealth;

    void Start()
    {
        _PosInitial = transform.position;
        _PlayerHealth = GetComponent<PlayerHealth>();
        _Move = GetComponent<Move>();
    }

    public void SetRespawn(Transform position)
    {
        _Respawn = position;
    }

    public void Respawn()
    {
        _Move.ResetVelocity();
        if(_Respawn != null)
        {
            transform.position = _Respawn.position;
        }
        else
        {
             transform.position = _PosInitial;
        }

        _PlayerHealth.LoseHealth();
    }
}

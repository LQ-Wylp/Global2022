using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCheckpoint : MonoBehaviour
{
    public Transform _Respawn;
    private Vector3 _PosInitial;
    private Move _Move;
    private PlayerHealth _PlayerHealth;

    public ParticleSystem DeathParticle;
    public Rigidbody2D rb2d;
   
    public GameObject VisuPlayer;

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


        _Move.enabled = false;
        rb2d.isKinematic = true;
        VisuPlayer.SetActive(false);
        DeathParticle.Emit(30);


        //invoque particule;

        StartCoroutine(Death());

        

        _PlayerHealth.LoseHealth();
    }

    IEnumerator Death()
    {
       
            yield return new WaitForSeconds(.5f);

        if (_Respawn != null)
        {
            transform.position = _Respawn.position;
            _Move.enabled = true;
            VisuPlayer.SetActive(true);
            rb2d.isKinematic = false;
        }
        else
        {
            transform.position = _PosInitial;
            rb2d.isKinematic = false;
            _Move.enabled = true;
            VisuPlayer.SetActive(true);
        }
    }
    
}

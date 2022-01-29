using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMonster : MonoBehaviour
{
    public bool _Activated;
    public float _Cooldown;
    public float _TempsAvantSpawnAuto;
    private float _TimeEffect;

    public GameObject _Monster;
    public Transform _SpawnPosition;

    void Update()
    {
        if(_Activated)
        {
            _TimeEffect += Time.deltaTime / Time.timeScale;
            if(_TimeEffect > _TempsAvantSpawnAuto)
            {
                Spawn();
            }
        }
    }

    public void Spawn()
    {
        Instantiate(_Monster, _SpawnPosition.position, Quaternion.identity);
        _SpawnPosition.gameObject.SetActive(false);
        _Activated = false;
    }

    public void Cast()
    {
        _Activated = true;
        _TimeEffect = 0;
        _SpawnPosition.gameObject.SetActive(true);
    }
}

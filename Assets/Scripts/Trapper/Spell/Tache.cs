using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tache : MonoBehaviour
{
    private bool _Activated;
    public float _Cooldown;
    public float _Duration;
    private float _TimeEffect;

    public GameObject _uiTache;

    void Update()
    {
        if(_Activated)
        {
            _TimeEffect += Time.deltaTime;
            if(_TimeEffect > _Duration)
            {
                _Activated = false;
                _uiTache.SetActive(false);
            }
        }
    }

    public void Cast()
    {
        _Activated = true;
        _TimeEffect = 0;
        _uiTache.SetActive(true);
    }
}

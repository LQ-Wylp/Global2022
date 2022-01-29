using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HackControls : MonoBehaviour
{
    public float _Cooldown;
    public float _Duration;
    public Move _Move;
    private float _TimeEffect;
    private bool _Activated;

    void Update()
    {
        if(_Activated)
        {
            _TimeEffect += Time.deltaTime;
            if(_TimeEffect > _Duration)
            {
                _Activated = false;
                _Move._InverseControls = false;
            }
        }
    }

    public void Cast()
    {
        Debug.Log("Hack Move");
        _TimeEffect = 0;

        _Activated = true;
        _Move._InverseControls = true;
    }
}

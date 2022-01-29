using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Acceleration : MonoBehaviour
{
    public float _Cooldown;
    public float _Duration;
    public Move _Move;
    private float _TimeEffect;
    private bool _Activated;
    public float _CoefSpeed;

    void Update()
    {
        if(_Activated)
        {
            _TimeEffect += Time.deltaTime;
            if(_TimeEffect > _Duration)
            {
                _Activated = false;
                _Move._coefSpeed = 1;
            }
        }
    }

    public void Cast()
    {
        Debug.Log("Acceleration");
        _TimeEffect = 0;

        _Activated = true;
        _Move._coefSpeed = _CoefSpeed;
    }
}

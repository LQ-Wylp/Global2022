using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TournerEcran : MonoBehaviour
{
    public float _Cooldown;
    public float _Duration;
    private float _TimeEffect;
    private float _PourcentageLerp;
    public float _SpeedRotate;

    private Transform _AncreCamera;
    private bool _Activated;

    private Quaternion _InitialRotate;
    public Quaternion _EndRotate;

    void Start()
    {
        _InitialRotate = transform.rotation;
        _AncreCamera = GameObject.FindGameObjectWithTag("AncreCamera").transform;
    }
    
    void Update()
    {
        if(_Activated && _TimeEffect > _Duration)
        {
            _PourcentageLerp += _SpeedRotate * Time.deltaTime;
            if(_PourcentageLerp > 1){_PourcentageLerp = 1;}
            transform.rotation = Quaternion.Lerp(_InitialRotate, _EndRotate, _PourcentageLerp);

            _TimeEffect += Time.deltaTime;

        }
        else if(_Activated && _TimeEffect > _Duration)
        {
            _PourcentageLerp -= _SpeedRotate * Time.deltaTime;
            if(_PourcentageLerp < 0){_PourcentageLerp = 0;}
            transform.rotation = Quaternion.Lerp(_InitialRotate, _EndRotate, _PourcentageLerp);

            if(_PourcentageLerp == 0)
            {
                _Activated = false;
            }

        }
    }

    public void TurnScreen()
    {
        _PourcentageLerp = 0;
        _TimeEffect = 0;

        _Activated = true;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TournerEcran : MonoBehaviour
{
    public float _Cooldown;
    public float _Duration;
    private float _TimeEffect;
    public float _PourcentageLerp;
    public float _SpeedRotate;

    public GameObject _AncreCamera;
    private bool _Activated;

    private Quaternion _InitialRotate;
    public Transform _EndRotate;

    void Start()
    {
        _InitialRotate = transform.rotation;
    }
    
    void Update()
    {
        if(_Activated && _TimeEffect < _Duration)
        {
            _PourcentageLerp += _SpeedRotate * Time.deltaTime;
            if(_PourcentageLerp > 1){_PourcentageLerp = 1;}
            _AncreCamera.transform.rotation = Quaternion.Lerp(_InitialRotate, _EndRotate.rotation, _PourcentageLerp);

            _TimeEffect += Time.deltaTime;

        }
        else if(_Activated && _TimeEffect > _Duration)
        {
            _PourcentageLerp -= _SpeedRotate * Time.deltaTime;
            if(_PourcentageLerp < 0){_PourcentageLerp = 0;}
            _AncreCamera.transform.rotation = Quaternion.Lerp(_InitialRotate, _EndRotate.rotation, _PourcentageLerp);

            if(_PourcentageLerp == 0)
            {
                _Activated = false;
            }

        }
    }

    public void Cast()
    {
        Debug.Log("Tourner Ecran");
        _PourcentageLerp = 0;
        _TimeEffect = 0;

        _Activated = true;
    }
}

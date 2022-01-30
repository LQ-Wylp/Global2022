using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoupVent : MonoBehaviour
{

    public float _Cooldown;
    public float _WindPower;
    public GameObject _Player;

    public float _Duration;
    private float _TimeEffect;
    private bool _Activated;

    public GameObject wind;

    void Update()
    {
        if(_Activated)
        {
            wind.SetActive(true);
            _TimeEffect += Time.deltaTime;
            float recul = _WindPower * Time.deltaTime;
            _Player.transform.position = new Vector3(_Player.transform.position.x - recul, _Player.transform.position.y, _Player.transform.position.z);

            if(_TimeEffect > _Duration)
            {
                wind.SetActive(false);
                _Activated = false;
            }
        }
    }

    public void Cast()
    {
        Debug.Log("Cout Vent");
        _TimeEffect = 0;

        _Activated = true;
    }
    
}

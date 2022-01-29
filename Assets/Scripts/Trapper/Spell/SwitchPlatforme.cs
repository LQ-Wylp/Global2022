using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchPlatforme : MonoBehaviour
{
    public float _Cooldown;
    public float _Duration;
    private float _TimeEffect;
    private bool _Activated;

    public List<PlateformVariable> _ListPlatformeVariable;

    public void AddList(PlateformVariable Pv)
    {
        _ListPlatformeVariable.Add(Pv);
    }
    void Update()
    {
        if(_Activated)
        {
            _TimeEffect += Time.deltaTime;
            if( _TimeEffect >= _Duration)
            {
                SwitchAllPlatform();
                _Activated = false;
            }
        }
    }
    
    private void SwitchAllPlatform()
    {
        for(int i = 0; i < _ListPlatformeVariable.Count; i++)
        {
            _ListPlatformeVariable[i].SwitchPlatform();
        }
    }

    public void Cast()
    {
        Debug.Log("Switch Plateform");
        _TimeEffect = 0;
        _Activated = true;
        SwitchAllPlatform();
    }
}

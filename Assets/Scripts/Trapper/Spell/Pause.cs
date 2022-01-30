using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    private bool _Activated;
    public float _Cooldown;
    public float _Duration;
    private float _TimeEffect;
    public GameObject IconePause;

    void Update()
    {
        if(_Activated)
        {
            _TimeEffect += Time.deltaTime / Time.timeScale;
            if(_TimeEffect > _Duration)
            {
                IconePause.SetActive(false);
                _Activated = false;
                Time.timeScale = 1;
            }
        }
    }

    public void Cast()
    {
        IconePause.SetActive(true);
        _Activated = true;
        _TimeEffect = 0;
        Time.timeScale = 0.001f;
    }
}

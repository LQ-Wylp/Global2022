using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tremblement : MonoBehaviour
{
    public float _Cooldown;
    public float _Duration;
    public Shake _Shake;
    public float _Force;

    public void Cast()
    {
        _Shake.Launch(_Duration, _Force);
    }
}

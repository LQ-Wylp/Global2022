using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NuageEclair : MonoBehaviour
{
    public float _Cooldown;
    public GameObject _Player;
    public GameObject _NuageEclair;

    public void Cast()
    {
        Instantiate(_NuageEclair,_Player.transform.position, Quaternion.identity);
    }
}

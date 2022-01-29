using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlateformVariable : MonoBehaviour
{
    public GameObject _goPhysique;
    public GameObject _goNonPhysique;

    private bool _Physique = true;

    public void Start()
    {
        GameObject.FindWithTag("SwitchPlateform").GetComponent<SwitchPlatforme>().AddList(this); 
    }

    public void SwitchPlatform()
    {
        _Physique = !_Physique;
        _goPhysique.SetActive(_Physique);
        _goNonPhysique.SetActive(!_Physique);
    }
}

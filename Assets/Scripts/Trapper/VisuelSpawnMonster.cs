using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisuelSpawnMonster : MonoBehaviour
{
    public Transform _pointA;
    public Transform _pointB;
    public float _speed;

    private float pourcentage;
    private int Etat = 0;

    void Update()
    {
        if(Etat == 0)
        {
            pourcentage += _speed * Time.deltaTime / Vector3.Distance(transform.position,_pointA.position);
            transform.position = Vector3.Lerp(transform.position, _pointA.position, pourcentage);
            if(pourcentage >= 1)
            {
                pourcentage = 0;
                Etat = 1;
            }
        }
        if(Etat == 1)
        {
            pourcentage += _speed * Time.deltaTime / Vector3.Distance(transform.position,_pointB.position);
            transform.position = Vector3.Lerp(transform.position, _pointB.position, pourcentage);
            if(pourcentage >= 1)
            {
                pourcentage = 0;
                Etat = 0;
            }
        }

    }
}

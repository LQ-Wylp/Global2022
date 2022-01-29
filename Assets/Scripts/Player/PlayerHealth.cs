using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerHealth : MonoBehaviour
{

    public int MaxHealth;
    private int HealthRemaining;

    public UnityEvent _NoHealth;
    
    void Start()
    {
        HealthRemaining = MaxHealth;
    }

    public void LoseHealth()
    {
        HealthRemaining--;
    }
    public void RegenHealth()
    {
        HealthRemaining++;
    }

    void Update()
    {
        if(HealthRemaining <= 0)
        {
            _NoHealth.Invoke();
        }
    }
}

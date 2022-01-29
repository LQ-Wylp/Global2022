using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class WinPoint : MonoBehaviour
{
    public UnityEvent _Win;
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            _Win.Invoke();
        }
    }
}

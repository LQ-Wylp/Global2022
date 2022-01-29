using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetCheckPoint : MonoBehaviour
{
    public Transform _WhereSpawn;

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            other.gameObject.GetComponent<PlayerCheckpoint>().SetRespawn(_WhereSpawn);
        }
    }
}

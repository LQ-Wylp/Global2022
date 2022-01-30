using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnUIHack : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject _PrefabUIHack;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Spawning()
    {
        Instantiate(_PrefabUIHack, transform);
        //_PrefabUIHack.transform.parent = gameObject.transform;
    }
}

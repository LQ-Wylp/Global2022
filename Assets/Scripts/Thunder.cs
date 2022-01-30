using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thunder : MonoBehaviour
{

    public GameObject Eclair1;
    public GameObject Eclair2;

    public float duration;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        duration -= Time.deltaTime;

        if (duration <= 0)
        {
            Eclair1.SetActive(true);
            Eclair2.SetActive(true);
        }
    }
}

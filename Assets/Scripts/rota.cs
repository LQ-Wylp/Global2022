using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rota : MonoBehaviour
{

    public float xAngle, yAngle, zAngle;
    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.Rotate(xAngle, yAngle, zAngle * Time.deltaTime, Space.Self);
    }
}

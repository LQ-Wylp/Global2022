using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneAuto : MonoBehaviour
{
    public float Duration;
    public string NameScene;

    // Update is called once per frame
    void Update()
    {
        Duration -= Time.deltaTime;
        if(Duration <= 0)
        {
            SceneManager.LoadScene(NameScene);
        }
    }
}

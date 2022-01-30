using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shake : MonoBehaviour
{
    public bool refreshCamera = false;

    Vector3 originalPos;

    private void Start()
    {
        originalPos = transform.localPosition;
    }

    public IEnumerator ShakeScreen (float duration, float magnitude)
    {
        float elapsed = 0.0f;

        while (elapsed < duration)
        {
            float x = Random.Range(-10f, 10f) * magnitude;
            float y = Random.Range(-1f, 1f) * magnitude;

            transform.localPosition = new Vector3(x, y, originalPos.z);

            elapsed += Time.deltaTime;

            yield return null;
        }

        transform.localPosition = originalPos;
    }
    public void Launch(float _Duration, float _Force)
    {
        StartCoroutine(ShakeScreen (_Duration, _Force));
    }
    private void Update()
    {
        if (refreshCamera == true)
        {
            transform.localPosition = originalPos;
            refreshCamera = false;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    public float duration = 1.5f;
    public float magnitude = 1.5f;
    

    public IEnumerator Shake()
    {
        Vector3 orginalPosition = transform.localPosition;
        float elapsed = 0f;
        while (elapsed < duration)
        {
            float x = Random.Range(-1f, 1f) * magnitude;
            float y = Random.Range(-1f, 1f) * magnitude;

            transform.localPosition = new Vector3(orginalPosition.x + x, orginalPosition.y + y, orginalPosition.z);
            elapsed += Time.deltaTime;

            yield return null;

        }

        transform.localPosition = orginalPosition;
    }




    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
}

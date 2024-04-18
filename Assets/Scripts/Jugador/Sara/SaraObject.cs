using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaraObject : MonoBehaviour
{
    float timer;
    [SerializeField] float lifetime;

    private void Update()
    {
        timer += Time.deltaTime;
        if (timer >= lifetime)
        {
            Destroy(gameObject);
        }
    }
}

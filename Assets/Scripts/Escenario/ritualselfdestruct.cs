using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ritualselfdestruct : MonoBehaviour
{
    GameObject hijo;

    private void Start()
    {
        hijo = GetComponentInChildren<GameObject>();
    }

    private void Update()
    {
        if (hijo != null)
        {
            Destroy(gameObject);
        }
    }
}

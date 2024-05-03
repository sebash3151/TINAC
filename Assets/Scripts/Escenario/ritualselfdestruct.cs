using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ritualselfdestruct : MonoBehaviour
{
    [SerializeField] GameObject hijo;

    private void Start()
    {
        //hijo = GetComponentInChildren<GameObject>();
    }

    private void Update()
    {
        if (hijo != null)
        {
            //Destroy(gameObject);
        }
    }
}

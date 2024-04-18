using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class distractionpoint : MonoBehaviour
{
    [SerializeField] Transform puntosombra;
    Transform yo;

    private void Start()
    {
        yo = GetComponent<Transform>();
    }

    private void Update()
    {
        if (puntosombra != null)
        {
            yo.transform.position = new Vector3(yo.transform.position.x, puntosombra.transform.position.y, yo.transform.position.z);
        }
    }
}

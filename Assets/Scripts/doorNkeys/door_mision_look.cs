using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door_mision_look : MonoBehaviour
{
    Doors puerta;

    private void Start()
    {
        puerta = GetComponent<Doors>();
    }

    private void Update()
    {
        puerta.open = false;
    }

}

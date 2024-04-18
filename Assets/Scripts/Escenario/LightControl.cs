using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightControl : MonoBehaviour
{
    [SerializeField]GameObject olight;
    Light mlight;
    void Start()
    {
        mlight = olight.GetComponent<Light>();
        mlight.enabled = false;
    }

    private void OnTriggerStay(Collider other)
    {
        GameObject jugador = other.gameObject;
        if (jugador.CompareTag("Player"))
        {
            mlight.enabled = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        GameObject jugador = other.gameObject;
        if (jugador.CompareTag("Player"))
        {
            mlight.enabled = false;
        }
    }

}

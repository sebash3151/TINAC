using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pentagram : MonoBehaviour
{
    Light luz;
    private void Start()
    {
        luz = GetComponent<Light>();
 
    }

    private void OnTriggerEnter(Collider other)
    {
        GameObject player = other.gameObject;
        if (player.CompareTag("Player"))
        {
            luz.enabled = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        GameObject player = other.gameObject;
        if (player.CompareTag("Player"))
        {
            luz.enabled = false;
        }
    }
}

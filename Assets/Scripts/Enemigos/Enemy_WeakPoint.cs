using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_WeakPoint : MonoBehaviour
{
    Shadow_Fade Desaparecer;
    [SerializeField] float timer;
    [SerializeField] float TiempoDeDaño = 1.5f;

    private void Start()
    {
        Desaparecer = GetComponentInParent<Shadow_Fade>();
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Linterna"))
        {
            timer += Time.deltaTime;
            if (timer >= TiempoDeDaño)
            {
                Desaparecer.Fade = true;
                timer = 0;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Linterna"))
        {
            timer = 0;
        }
    }

}

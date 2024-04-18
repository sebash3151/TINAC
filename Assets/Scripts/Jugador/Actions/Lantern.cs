using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lantern : MonoBehaviour

{
    Light Litch;

    [SerializeField] float Switche;

    CapsuleCollider LinternaRange;

    AudioSource Switch;

   

    [SerializeField] float TimerLuz;

    void Start()
    {
        Litch = GetComponent<Light>();
        LinternaRange = GetComponent<CapsuleCollider>();
        Switch = GetComponent<AudioSource>();
    }


    void Update()
    {
        if (Switche == 1f)
        {
            Encender();
        }
   
        if (Switche == 0f)
        {
            Apagar();
        }

        if (Switche == 0f && Input.GetButtonDown("Fire1"))
        {
            Switche = 1f;
            if (!Switch.isPlaying) Switch.Play();
        }
        else if (Switche == 1f && Input.GetButtonDown("Fire1"))
        {
            Switche = 0f;
            if (!Switch.isPlaying) Switch.Play();
        }
    }

    void Encender()
    {
        Litch.range = 20f;
        LinternaRange.enabled = true;
    }
    void Apagar()
    {
        Litch.range = 0f;
        LinternaRange.enabled = false;
    }
}

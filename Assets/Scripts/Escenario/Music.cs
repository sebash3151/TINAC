using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    AudioSource Musica;

    void Start()
    {
        Musica = GetComponent<AudioSource>();
    }

    public void Desactivar()
    {
        Musica.volume = 0;
    }

    public void Activar()
    {
        Musica.volume = 1;
    }
}

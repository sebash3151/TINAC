using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButtons : MonoBehaviour
{
    AudioSource sonido;

    private void Start()
    {
        sonido = GetComponent<AudioSource>();
    }

    public void sonar()
    {
        sonido.Play();
    }

}

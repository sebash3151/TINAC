using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VistaMatrona : MonoBehaviour
{
    ControlMatrona control;// llama al controlador de estados
    AudioSource Gri;
    void Start()
    {
        Gri = GetComponentInParent<AudioSource>();
        control = GetComponentInParent<ControlMatrona>();
    }

    private void OnTriggerEnter(Collider other)//si entra al trigger de la vista lo persigue
    {
        if (other.CompareTag("Player"))
        {
            Gri.Play();
            control.Estado = 1;
        }
    }
    private void OnTriggerExit(Collider other)//si sale del trigger la matrona deja de perseguirle
    {
        if (other.CompareTag("Player"))
        {
            control.Estado = 0;
        }
    }
}

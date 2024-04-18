using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class proximidadmatrona : MonoBehaviour
{
    AudioSource DangerSong;
    [SerializeField] Music musik;

    private void Start()
    {
        DangerSong = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            DangerSong.Play();
            musik.Desactivar();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            DangerSong.Pause();
            musik.Activar();
        }
    }
}

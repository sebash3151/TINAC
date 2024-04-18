using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Letters : MonoBehaviour
{
    [SerializeField] GameObject Note;
    [SerializeField] GameObject fade;
    int contador = 0;
    AudioSource papel;

    private void Start()
    {
        papel = GetComponent<AudioSource>();
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player") && Input.GetKeyDown("e") && contador == 0)
        {
            fade.SetActive(true);
            Note.SetActive(true);
            contador++;
            papel.Play();
        }else if(other.CompareTag("Player") && Input.GetKeyDown("e") && contador == 1)
        {
            fade.SetActive(false);
            Note.SetActive(false);
            contador = 0;
            papel.Play();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            fade.SetActive(false);
            Note.SetActive(false);
            contador = 0;
            papel.Play();
        }
    }
}

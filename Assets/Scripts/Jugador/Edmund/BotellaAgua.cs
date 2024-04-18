using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotellaAgua : MonoBehaviour
{
    [SerializeField] float duracion = 4;
    float contador = 0;
    void Update()
    {
        contador += Time.deltaTime;
        if (contador >= duracion) Destroy(gameObject);
    }
    private void OnTriggerEnter(Collider other)
    {
        GameObject enemigo = other.gameObject;
        if (enemigo.CompareTag("Sombra"))
        {
            Shadow_Fade ataque = enemigo.GetComponent<Shadow_Fade>();
            ataque.Fade = true;
            Destroy(gameObject);
        }
    }
}

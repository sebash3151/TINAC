using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ritos : MonoBehaviour
{
    [SerializeField] float tiempoDestruccion = 5;
     float contador = 0;
    [SerializeField] RitualesDestruidos destru;
    [SerializeField] GameObject barra;
    [SerializeField] Slider carga;

    private void Start()
    {
        if (Player_Difficult_selector.Difficult == 1)
        {
            tiempoDestruccion = tiempoDestruccion / 2;
        }
        if (Player_Difficult_selector.Difficult == 3)
        {
            tiempoDestruccion = tiempoDestruccion * 2;
        }
        carga.maxValue = tiempoDestruccion;
    }

    private void Update()
    {
        carga.value = contador;
    }

    private void OnTriggerStay(Collider other)
    {
        GameObject rito = other.gameObject;
        bool presionar = Input.GetKey("e");
        bool ritual = rito.CompareTag("Ritual");


        if (presionar && ritual)
        {
            contador += Time.deltaTime;
            barra.SetActive(true);
            if (contador >= tiempoDestruccion)
            {
                Destroy(rito);
                contador = 0;
                destru.destruido();
                barra.SetActive(false);
            }
        }
        if (presionar == false && contador < tiempoDestruccion) contador = 0;
      
    }
    private void OnTriggerExit(Collider other)
    {
        GameObject ritual = other.gameObject;
        if (ritual.CompareTag("Ritual")) contador = 0;
        barra.SetActive(false);
    }
}

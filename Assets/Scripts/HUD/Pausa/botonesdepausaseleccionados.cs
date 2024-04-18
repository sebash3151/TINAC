using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class botonesdepausaseleccionados : MonoBehaviour
{
    [SerializeField] BotonSeleccionado[] botoncitos;
    int position = 0;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            botoncitos[position].seleccionado = false;
             position++;

             if (position < 0)
             {
                 position = botoncitos.Length - 1;
                botoncitos[position].seleccionado = true;
                 return;
             }
             if (position > botoncitos.Length - 1)
             {
                 position = 0;
                botoncitos[position].seleccionado = true;
                 return;
             }

            botoncitos[position].seleccionado = true;
         }

         if (Input.GetKeyDown(KeyCode.S))
         {
            botoncitos[position].seleccionado = false;
             position--;

             if (position < 0)
             {
                 position = botoncitos.Length - 1;
                botoncitos[position].seleccionado = true;
                 return;
             }
             if (position > botoncitos.Length - 1)
             {
                 position = 0;
                botoncitos[position].seleccionado = true;
                 return;
             }

            botoncitos[position].seleccionado = true;
         }
    }
}



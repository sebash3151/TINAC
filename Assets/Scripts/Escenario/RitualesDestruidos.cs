using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RitualesDestruidos : MonoBehaviour
{
    [SerializeField] int rituales;
    [SerializeField] int contador;
    [SerializeField] Doors[] puertas;

    public void destruido()
    {
        contador++;
    }

    private void Update()
    {
        if (contador == rituales)
        {
            for (int i = 0; i < puertas.Length; i++)
            {
                puertas[i].open = true;
            }
        }
    }
}

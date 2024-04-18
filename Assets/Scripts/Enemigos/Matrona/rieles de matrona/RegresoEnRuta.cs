using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;


public class RegresoEnRuta : MonoBehaviour
{
    GameObject Matrona;
    CinemachineDollyCart Carrito;
    float velocidad;
    [SerializeField] float menos;//debe ajustar este valor a uno o a menos uno. dependiendo de si es el final de la vida o no.

    void Start()
    {
        Matrona = GameObject.Find("Matrona");
        Carrito = Matrona.GetComponent<CinemachineDollyCart>();
        velocidad = Carrito.m_Speed;
    }

   
    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Matrona"))//modifica la velocidad del dollytrack
        {
            Carrito.m_Speed = (velocidad * menos);
        }
        
    }
}

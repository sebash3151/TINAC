using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PerseguirMatrona : MonoBehaviour
{
    NavMeshAgent Agente;
   [SerializeField]Transform jugador;
    GameObject pla;
  
    //script para que persiga al jugador
    void Awake()
    {
        pla = GameObject.FindGameObjectWithTag("Player");
        jugador = pla.GetComponent<Transform>();
        Agente = GetComponent<NavMeshAgent>();
    }
    void Update()
    {
        Agente.SetDestination(jugador.position);
    }
}

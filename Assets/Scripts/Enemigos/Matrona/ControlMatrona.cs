using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Cinemachine;

public class ControlMatrona : MonoBehaviour
{

    [SerializeField] public int Estado = 0;//0="patrullando" 1=persiguiendo al jugador.
    GameObject Juga;
    NavMeshAgent persecucion;
    PerseguirMatrona perseguir;
    Player_Life Ch;
    CinemachineDollyCart patrulla;
   
    void Start()
    {
       
        Juga = GameObject.FindGameObjectWithTag("Player");
        Ch = Juga.GetComponent<Player_Life>();
        persecucion = GetComponent<NavMeshAgent>();
        patrulla = GetComponent<CinemachineDollyCart>();
        perseguir = GetComponent<PerseguirMatrona>();
    }

 
    void Update()
    {

        Escondido();

        if (Estado == 0)//estado de patrullar
        {
            persecucion.enabled = false;
            perseguir.enabled = false;
            patrulla.enabled = true;
        }
        else if (Estado == 1 )//Estado de perseguir
        {
            persecucion.enabled = true;
            patrulla.enabled = false;
            perseguir.enabled = true;
            
        }

    }
    void Escondido()
    {
        if (Ch.Escondido == true)
        {
            Estado = 0;
        }
    }
}

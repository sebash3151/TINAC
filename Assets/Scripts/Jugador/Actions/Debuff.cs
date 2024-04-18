using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Debuff : MonoBehaviour
{
    public bool Ralentizado;
    float time;
    Player_moverse jugador;
    [SerializeField] float MaldicionSombra;
    [SerializeField] float TiempoDebuff;
    
   
    void Start()
    {
        jugador = GetComponent<Player_moverse>();
    }

    void Update()
    {
        if(Ralentizado)
        {
            time += Time.deltaTime;
            jugador.movementSpeed = jugador.movementSpeed / MaldicionSombra;
        }

        if (time >= TiempoDebuff)
        {
            time = 0;
            jugador.movementSpeed = jugador.movementSpeed * MaldicionSombra;
        }
    }
}

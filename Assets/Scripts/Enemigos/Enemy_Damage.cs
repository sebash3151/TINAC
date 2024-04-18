using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy_Damage : MonoBehaviour
{
    [SerializeField] float AttackSpeed = 0.5f;
    float timer;
    Player_Life vida;
    Player_moverse movimiento;
    [SerializeField] int DañoSombra = 30;
    [SerializeField] int DañoBestia = 40;
    [SerializeField] int DañoMatrona = 50;
    float contadorDos = 0;
    [SerializeField] Image stamina;
    Color morado = new Color(1f, 0, 1f);
    private void Start()
    {
        vida = FindObjectOfType<Player_Life>();
        movimiento = FindObjectOfType<Player_moverse>();
        stamina = stamina.GetComponent<Image>();
        facil();
        Dificil();
    }

    void Update()
    {
        Contador();
        
    }

    void Contador()
    {
        timer += Time.deltaTime;

    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            vida = other.GetComponent<Player_Life>();
            Ataque();
        }
    }

    void Ataque()
    {
        if (timer >= AttackSpeed)
        {
            timer = 0;
            if (vida.VidaActual > 0)
            {
                if (vida.Escondido == false)
                {
                    if (this.CompareTag("Sombra"))
                    {
                        vida.VidaActual -= DañoSombra;
                        vida.daño();
                        contadorDos += Time.deltaTime;
                     
                        movimiento.movementSpeed /= 2;
                        stamina.color = morado;

                        if(contadorDos >= 5f)
                        {
                            movimiento.movementSpeed = movimiento.movimientonormal;
                            contadorDos = 0;
                        }

                    }
                    else if (this.CompareTag("Bestia"))
                    {
                        vida.VidaActual -= DañoBestia;
                        vida.daño();
                    }
                    else if (this.CompareTag("Matrona"))
                    {
                        vida.VidaActual -= DañoMatrona;
                        vida.daño();
                    }
                }else if (vida.Escondido == true)
                {

                }
            }           
        }
    }

    void facil()
    {
        if (Player_Difficult_selector.Difficult == 1)
        {
            DañoSombra = DañoSombra / 2;
            DañoMatrona = DañoMatrona / 2;
            DañoBestia = DañoBestia / 2;
        }
    }

    void Dificil()
    {
        if (Player_Difficult_selector.Difficult == 3)
        {
            DañoSombra = DañoSombra * 2;
            DañoMatrona = DañoMatrona * 2;
            DañoBestia = DañoBestia * 2;
        }
    }
}

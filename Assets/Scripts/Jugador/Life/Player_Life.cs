using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_Life : MonoBehaviour
{
    public float VidaInicial = 100;
    public float VidaActual;
    Rigidbody RigiPlayer;
    [SerializeField] Slider VidaSlider;

    AudioSource Hurt;

    [SerializeField] HuD_Control HUD;

    public bool Escondido = false;

    Player_moverse mover;

    void Start()
    {
        VidaActual = VidaInicial;
        RigiPlayer = GetComponent<Rigidbody>();
        Hurt = GetComponent<AudioSource>();
        mover = GetComponent<Player_moverse>();
    }


    void Update()
    {
        Muerte();
        Actualizar_SliderVida();
        MantenerVida();
    }

    void Muerte()
    {
        if (VidaActual <= 0)
        {
            HUD.Death();
            mover.movementSpeed = 0f;
        }
    }

    void Actualizar_SliderVida()
    {
        VidaSlider.value = VidaActual;
    }

    void MantenerVida()
    {
        if (VidaActual > VidaInicial)
        {
            VidaActual = VidaInicial;
        }
    }

    public void daño()
    {
        Hurt.Play();
        HUD.Hurt();
    }
}

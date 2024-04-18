using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vida_Critica_ValorSlider : MonoBehaviour
{
    Animator anim;
    Player_Life vida;
    Slider slider;

    void Start()
    {
        anim = GetComponent<Animator>();
        vida = FindObjectOfType<Player_Life>();
        slider = GetComponent<Slider>();
        slider.maxValue = vida.VidaInicial;
    }

    void Update()
    {
        Critico();
    }

    void Critico()
    {
        if (vida.VidaActual <= 30)
        {
            anim.SetBool("Critica", true);
        }
        else
        {
            anim.SetBool("Critica", false);
        }
    }
}

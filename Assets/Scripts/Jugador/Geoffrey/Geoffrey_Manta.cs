using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Geoffrey_Manta : MonoBehaviour
{
    bool manta;
    [SerializeField] float cooldown = 5f;
    [SerializeField] float tiempodeuso = 5f;
    float controltiempodeuso = 5f;
    float tiempodeespera = 0f;
    Player_moverse move;
    bool esperacooldown;

    [SerializeField] Slider powerbar;
    [SerializeField] Slider usobar;
    [SerializeField] GameObject usos;
    [SerializeField] GameObject mantita;
    [SerializeField] AudioSource cobija;

    Player_Life vida;

    private void Start()
    {
        controltiempodeuso = tiempodeuso;
        powerbar.maxValue = cooldown;
        powerbar.value = cooldown;
        usobar.maxValue = tiempodeuso;
        usobar.value = tiempodeuso;
        vida = GetComponent<Player_Life>();
    }

    private void Update()
    {
        move = GetComponent<Player_moverse>();
        Manta();
        Enfriamiento();
    }

    void Manta()
    {
        if (Input.GetButtonDown("Fire2") && controltiempodeuso >=tiempodeuso && manta == false)
        {
            usos.SetActive(true);
            manta = true;
            tiempodeespera = 0f;
            move.movementSpeed = 0f;
            vida.Escondido = true;
            mantita.SetActive(true);
            cobija.Play();
        }

        if (manta == true)
        {
            controltiempodeuso -= Time.deltaTime;
            usobar.value = controltiempodeuso;
        }

        if (Input.GetButtonUp("Fire2")  || controltiempodeuso <= 0)
        {
            manta = false;
            move.movementSpeed = move.movimientonormal;
            esperacooldown = true;
            powerbar.value = 0;
            usos.SetActive(false);
            vida.Escondido = false;
            mantita.SetActive(false);
        }

    }

    void Enfriamiento()
    {

        if (esperacooldown)
        {
            tiempodeespera += Time.deltaTime;
            powerbar.value = tiempodeespera;
        }

        if (tiempodeespera >= cooldown)
        {
            controltiempodeuso = tiempodeuso;
            tiempodeespera = 0f;
            esperacooldown = false;
            powerbar.value = cooldown;
        }
    }

}

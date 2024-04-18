using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaraAbility : MonoBehaviour
{
    [SerializeField] GameObject Distraction;
    [SerializeField] Transform RefPosition;
    [SerializeField] float Cooldown;
    float Timer = 3f;
    [SerializeField] Transform distraction;
    [SerializeField] Transform sombra;
    Transform sara;

    [SerializeField] Slider powerbar;
    [SerializeField] GameObject uso;
    [SerializeField] float tiempodevida = 3f;
    float controlvida;
    [SerializeField] Slider usobar;
    bool muñeco;
    float contador = 0;
    Player_Life vida;
   

    private void Start()
    {
        powerbar.maxValue = Cooldown;
        powerbar.value = Cooldown;
        usobar.maxValue = tiempodevida;
        usobar.value = tiempodevida;
        controlvida = tiempodevida;
        sara = GetComponent<Transform>();
        vida = FindObjectOfType<Player_Life>();
    }

    void Update()
    {
        Timer += Time.deltaTime;

        if (Input.GetButtonDown("Fire2") && Timer >= Cooldown)
        {
            Instantiate(Distraction, RefPosition.position, RefPosition.rotation);
            Timer = 0;
            distraction.position = this.transform.position;
            distraction.SetParent(sombra);
            uso.SetActive(true);
            muñeco = true;
            contador++;
            if (contador >= 3)
            {
                vida.VidaActual -= (vida.VidaActual) * 0.2f;
                contador = 0;
            }
        }

        if (muñeco)
        {
            controlvida -= Time.deltaTime;
        }

        if (controlvida <= 0)
        {
            uso.SetActive(false);
            controlvida = tiempodevida;
            muñeco = false;
            distraction.SetParent(sara);
        }

        powerbar.value = Timer;
        usobar.value = controlvida;
    }
}

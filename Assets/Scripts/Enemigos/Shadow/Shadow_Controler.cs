using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shadow_Controler : MonoBehaviour
{
    Shadow_Fade sombra;
    float timer;

    Shadow_Comportamiento movimiento;
    public AudioSource DangerSong;

    [SerializeField] Music musik;
    [SerializeField] AudioSource Grito;
    public AudioSource Shout;
    [SerializeField] door_mision_look entrada;
    [SerializeField] door_mision_look salida;
    [SerializeField] bool complete;

    float tiempodemoricion = 2f;
    float timer2;

    void Start()
    {
        sombra = GetComponentInChildren<Shadow_Fade>();
        movimiento = GetComponentInChildren<Shadow_Comportamiento>();
        DangerSong = GetComponent<AudioSource>();
    }

    void Update()
    {
        RespawnShadow();
        puertas();
        moricion();
    }

    void RespawnShadow()
    {
        if (sombra.Fade)
        {
            Shout.Play();
            timer += Time.deltaTime;
        }

        if (timer >= 5)
        {
            if (sombra.ContadorDeFades < sombra.LimiteDeFade)
            {
                sombra.Reaparecer();
                sombra.Fade = false;
                timer = 0;
            }
        }
    }

    void moricion()
    {
        if (sombra.ContadorDeFades == sombra.LimiteDeFade)
        {
            timer2 += Time.deltaTime;
            if (timer2 >= tiempodemoricion)
            {
                Destroy(gameObject);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Grito.Play();
            movimiento.enabled = true;
            DangerSong.Play();
            musik.Desactivar();
            entrada.enabled = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            DangerSong.Pause();
            musik.Activar();
        }
    }

    void puertas()
    {
        if (sombra.ContadorDeFades >= sombra.LimiteDeFade)
        {
            entrada.enabled = false;
            salida.enabled = false;
            complete = true;
            DangerSong.Stop();
            musik.Activar();
        }
    }
}

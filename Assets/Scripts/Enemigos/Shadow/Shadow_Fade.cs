using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shadow_Fade : MonoBehaviour
{
    public bool Fade;
    public int ContadorDeFades;
    public int LimiteDeFade;
    Shadow_Controler control;

    private void Start()
    {
        control = GetComponentInParent<Shadow_Controler>();
    }

    void Update()
    {
        Desaparecer();
        Morir();
    }

    void Desaparecer()
    {
        if (Fade && ContadorDeFades < LimiteDeFade)
        {
            this.gameObject.SetActive(false);
            ContadorDeFades++;
        }
    }

    void Morir()
    {
        if (ContadorDeFades == LimiteDeFade)
        {
            Destroy(gameObject);
        }
    }

    public void Reaparecer()
    {
        if (ContadorDeFades < LimiteDeFade)
        {
            this.gameObject.SetActive(true);
            control.Shout.Play();
        }
    }
}

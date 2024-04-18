using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shadow_Comportamiento : MonoBehaviour
{
    Shadow_Fade Fade;
    Rigidbody ShadowRigi;
    [SerializeField] Transform[] Posiciones;
    int NextPosicion = 1;
    [SerializeField] float[] ShadowSpeed;
    int Aumento;
    public float velocidad;

    void Start()
    {
        Fade = GetComponent<Shadow_Fade>();
        ShadowRigi = GetComponent<Rigidbody>();
    }

    void Update()
    {
        AumentoDeVelocidada();
        Movement();
    }

    void AumentoDeVelocidada()
    {
        if (Fade.ContadorDeFades == 0)
        {
            Aumento = 0;
        }
        else if (Fade.ContadorDeFades == 1)
        {
            Aumento = 1;
        }
        else if (Fade.ContadorDeFades == 2)
        {
            Aumento = 2;
        }
        else if (Fade.ContadorDeFades == 3)
        {
            Aumento = 3;
        }
        else if (Fade.ContadorDeFades == 4)
        {
            Aumento = 4;
        }
        else if (Fade.ContadorDeFades == 5)
        {
            Aumento = 5;
        }
    }

    void Movement()
    {
        velocidad = ShadowSpeed[Aumento] * Time.deltaTime;
        this.transform.LookAt(Posiciones[NextPosicion]);
        ShadowRigi.MovePosition(Vector3.MoveTowards(ShadowRigi.position, Posiciones[NextPosicion].position, velocidad));

        if (Vector3.Distance(ShadowRigi.position, Posiciones[NextPosicion].position) <= 0)
        {
            NextPosicion=Random.Range(0,Posiciones.Length);
        }
    }
}

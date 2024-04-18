using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Difficult_selector : MonoBehaviour
{
    public static int Personaje;
    public static int Difficult;
    int perso;
    int difi;
    [SerializeField] int info;
    [SerializeField] int info2;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    private void Update()
    {
        Personaje = perso;
        Difficult = difi;
        info = Personaje;
        info2 = Difficult;
    }

    public void Sara()
    {
        perso = 0;
    }

    public void Edmund()
    {
        perso = 1;
    }

    public void Geoffrey()
    {
        perso = 2;
    }

    public void facil()
    {
        difi = 1;
    }

    public void Medio()
    {
        difi = 2;
    }

    public void Dificil()
    {
        difi = 3;
    }
}

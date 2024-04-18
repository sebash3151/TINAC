using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jadeos_Player : MonoBehaviour
{
    AudioSource Jadeos;
    Player_moverse move;

    void Start()
    {
        Jadeos = GetComponent<AudioSource>();
        move = GetComponentInParent<Player_moverse>();
    }

    void Update()
    {
        cansancio();
    }

    void cansancio()
    {
        if (move.cansado == true)
        {
            if (!Jadeos.isPlaying) Jadeos.Play();
        }
        else
        {
            Jadeos.Stop();
        }
    }
}
